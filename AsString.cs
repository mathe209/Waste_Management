using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public static class Extensions //extension method
    {
        //the "this" keyword shows which type will be extended
        //'value' is what's returned by the methods in the Products class
        public static string AsString(this decimal value, int decimalPlaces)
        {
            //using the math library to round the value
            decimal resul = Math.Round(value,decimalPlaces);
            return resul.ToString();
        }
    }
}
