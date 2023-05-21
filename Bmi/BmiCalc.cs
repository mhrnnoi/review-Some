using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bmi
{
    public class BmiCalc
    {
        

        public static string Bmi(double height, double weight)
        {
            if (height > 5)
            {
                height /= 100;
            }
            var bmi = weight / Math.Pow(height, 2);

            if (bmi > 40)
            {
                return "Very severely obese";
            }
            else if (bmi > 35)
            {
                return "severely obese";
            }
            else if (bmi > 30)
            {
                return "moderetely obese";
            }
            else if (bmi > 25)
            {
                return "overweight";
            }
            else if (bmi > 18.5)
            {
                return "normal";
            }
            else if (bmi > 16)
            {
                return "underweight";
            }
            else if (bmi > 15)
            {
                return "severely under weight";
            }
            else
            {
                return "very severely under weight";
            }

        }
    }
}