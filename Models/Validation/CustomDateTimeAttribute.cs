using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace YourTour.Models.Validation
{
    [AttributeUsage(AttributeTargets.Property)]
    public class CustomDateTimeAttribute : ValidationAttribute
    {
        public CustomDateTimeAttribute(string errorMessage) : base(errorMessage) {  }
        public override bool IsValid(object value)
        {
            if (value == null) return false;
            DateTime? dateTime = value as DateTime?;
            if (dateTime.HasValue)
            {
                return dateTime.Value >= DateTime.Now/* && dateTime.Value <= DateTime.Now.AddDays(50)*/;
            }
            return false;
        }
    }
}
