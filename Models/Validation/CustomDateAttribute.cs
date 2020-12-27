using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YourTour.Models.Validation
{
    [AttributeUsage(AttributeTargets.Property)]
    public class CustomDateAttribute : ValidationAttribute
    {
        public CustomDateAttribute(string errorMessage) : base(errorMessage) { }

        public override bool IsValid(object value)
        {
            if (value == null) return false;

            DateTime? dateTime = value as DateTime?;

            if (dateTime.HasValue)
            {
                return dateTime.Value >= DateTime.Now.AddDays(15)/* && dateTime.Value <= DateTime.Now.AddDays(50)*/;
            }

            return false;
        }
    }
}
