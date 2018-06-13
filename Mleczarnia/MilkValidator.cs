using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Mleczarnia
{
    class MilkValidator : ValidationRule
    {
        public MilkValidator() { }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            MleczarniaDBEntities2 db = new MleczarniaDBEntities2();
            var tanks = db.Tank;
            Tank tank = db.Tank.Single(a => a.tankID == 1);
            string v = value.ToString();
            float capacity = 0; ;
            float filling = 0;
            capacity = (float)tank.tankCapacity;
            filling = (float)tank.tankFilling;
            float vv = float.Parse(v, CultureInfo.InvariantCulture.NumberFormat);

            try
            {
                if ((vv + filling <= capacity))
                {
                    return ValidationResult.ValidResult;
                }
                else
                    return new ValidationResult(false, "Przekroczenie pojemności zbiornika!!!");
            }
            catch (Exception e)
            {
                return new ValidationResult(false, e.Message);
            }
        }
    }
}
