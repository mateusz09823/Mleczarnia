using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Mleczarnia
{
    class NIPRule : ValidationRule
    {
        public NIPRule() { }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            try
            {
                if ((int)value.ToString().Length == 9)
                {
                    return ValidationResult.ValidResult;
                }
                else
                    return new ValidationResult(false, "Illegar number of characters");
            }
            catch(Exception e)
            {
                return new ValidationResult(false, e.Message);
            }
            
        }
    }
}
