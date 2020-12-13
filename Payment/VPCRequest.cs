using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using System.Text;
using System.Web;
using System.Security.Cryptography;

namespace YourTour.Payment
{
    public class VPCRequest
    {
        private Uri _address;
        private SortedList<String, String> _requestData = new SortedList<String, String>(new VPCStringComparer());
        private SortedList<String, String> _responseData = new SortedList<String, String>(new VPCStringComparer());
        private string _rawResponse;
        private string _secureSecret;

        public VPCRequest(string URL)
        {
            _address = new Uri(URL);
        }
        public void SetSecureSecret(string secureSecret)
        {
            _secureSecret = secureSecret;
        }
        public void GetRequestData(string key, string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                _requestData.Add(key, value);
            }
        }
        public string GetResponseData(string key, string defValue)
        {
            string value;
            if(_responseData.TryGetValue(key, out value))
            {
                return value;
            }
            else
            {
                return defValue;
            }
        }
        public string GetResponseData(string key)
        {
            return GetResponseData(key, "");
        }
        private string GetRequestRaw()
        {
            StringBuilder data = new StringBuilder();
            foreach (KeyValuePair<string, string> kvp in _requestData)
            {
                if (!string.IsNullOrEmpty(kvp.Value))
                {
                    data.Append(kvp.Key + "=" + HttpUtility.UrlEncode(kvp.Value) + "&");
                }
            }
            if (data.Length > 0)
            {
                data.Remove(data.Length - 1, 1);
            }
            return data.ToString();
        }
        public void AddDigitalOrderField(String key, String value)
        {
            if (!String.IsNullOrEmpty(value))
            {
                _requestData.Add(key, value);
            }
        }

        //Payment processing
        public string Create3rdPartyQueryString()
        {
            StringBuilder url = new StringBuilder();

            //payment server url
            url.Append(_address);
            url.Append("?");

            //create url encoded request string from requestData
            url.Append(GetRequestRaw());

            //hash the requestData
            url.Append("&vpc_SecureHash=");
            url.Append(CreateSHA256Signature(true));
            return url.ToString();
        }
        public string Process3rdPartyResponse(System.Collections.Specialized.NameValueCollection nameValueCollection)
        {
            foreach (string item in nameValueCollection)
            {
                if (!item.Equals("vpc_SecureHash") && !item.Equals("vpc_SecureHashType"))
                {
                    _responseData.Add(item, nameValueCollection[item]);
                }

            }

            if (!nameValueCollection["vpc_TxnResponseCode"].Equals("0") && !String.IsNullOrEmpty(nameValueCollection["vpc_Message"]))
            {
                if (!String.IsNullOrEmpty(nameValueCollection["vpc_SecureHash"]))
                {
                    if (!CreateSHA256Signature(false).Equals(nameValueCollection["vpc_SecureHash"]))
                    {
                        return "INVALIDATED";
                    }
                    return "CORRECTED";
                }
                return "CORRECTED";
            }

            if (String.IsNullOrEmpty(nameValueCollection["vpc_SecureHash"]))
            {
                return "INVALIDATED";//no sercurehash response
            }
            if (!CreateSHA256Signature(false).Equals(nameValueCollection["vpc_SecureHash"]))
            {
                return "INVALIDATED";
            }
            return "CORRECTED";
        }

        //
        private class VPCStringComparer : IComparer<String>
        {
            public int Compare(string a, string b)
            {

                //so sánh 
                if (a == b)
                    return 0;
                if (a == null)
                    return -1;
                if (b == null)
                    return 1;

                //kiểm tra a và b là string
                string sa = a as string;
                string sb = b as string;

                //
                var comparer = CompareInfo.GetCompareInfo("en-US");
                if (sa != null && sb != null)
                {
                    return comparer.Compare(sa, sb, CompareOptions.Ordinal);
                }
                throw new ArgumentException("a và b phải là chuỗi");
            }
        }

        //SHA265 Hash Code
        public string CreateSHA256Signature(bool userRequest)
        {
            byte[] convertHash = new byte[_secureSecret.Length / 2];
            for (int i = 0; i < _secureSecret.Length / 2; i++)
            {
                convertHash[i] = (byte)Int32.Parse(_secureSecret.Substring(i * 2, 2), System.Globalization.NumberStyles.HexNumber);
            }

            //build string from collection in prepareration to ba hashed
            StringBuilder sb = new StringBuilder();
            SortedList<String, String> list = (userRequest ? _requestData : _responseData);
            foreach (KeyValuePair<string, string> kvp in list)
            {
                if(kvp.Key.StartsWith("vpc_") || kvp.Key.StartsWith("user_"))
                {
                    sb.Append(kvp.Key + "=" + kvp.Value + "&");
                }
            }

            //remove &
            if (sb.Length > 1)
            {
                sb.Remove(sb.Length - 1, 1);
            }
            //create secure hash
            string hexHash = "";
            using(HMACSHA256 hasher = new HMACSHA256(convertHash))
            {
                byte[] hashValue = hasher.ComputeHash(Encoding.UTF8.GetBytes(sb.ToString()));
                foreach (byte b in hashValue)
                {
                    hexHash += b.ToString("X2");
                }
            }
            return hexHash;
        }
    }
}
