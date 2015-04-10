using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WorkerApp
{
    class MyValidationRules : ValidationRule
    {
        //validation rules for text boxes
        public override ValidationResult Validate(object value, CultureInfo ultureInfo)
        {
            if (value == null || !Regex.Match(value.ToString(), "(^[a-zA-Z]*$)|(^[א-ת]*$)").Success)
            {
                return new ValidationResult(false, "The value is not a valid Name");
            }
            else
            { 
                return new ValidationResult(true, null);
            }
        }
    }
}
