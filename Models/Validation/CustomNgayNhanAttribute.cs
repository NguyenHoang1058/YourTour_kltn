using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace YourTour.Models.Validation
{
    [AttributeUsage(AttributeTargets.Property)]
    public class CustomNgayNhanAttribute : ValidationAttribute
    {
        public CustomNgayNhanAttribute(string errorMessage) : base(errorMessage) { }
        public override bool IsValid(object value)
        {
            if (value == null) return false;
            DateTime? dateTime = value as DateTime?;
            if (dateTime.HasValue)
            {
                return dateTime.Value >= DateTime.Now;
            }
            return false;
        }
    }
}
