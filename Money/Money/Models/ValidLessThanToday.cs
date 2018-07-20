using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Money.Models
{
    public sealed class ValidLessThanToday : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            DateTime inputDate = Convert.ToDateTime(value);

            if (inputDate <= DateTime.Now)
            {
                return ValidationResult.Success;

            }
            else
            {
                return new ValidationResult("日期不可大於今天");
            }


        }
    }
}