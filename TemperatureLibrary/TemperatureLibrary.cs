using System;

namespace TemperatureLibrary
{
    public class TempConvert
    {
        public static double Conversion(double temp, string op)
        {
            double result = double.NaN;

            switch (op)
            {
                case "a":
                    result = (temp - 32.0) * (5.0 / 9.0);
                    break;
                case "b":
                    result = (temp - 32.0) * (5.0 / 9.0) + 273.15;
                    break;
                case "c":
                    result = (temp * 5.0 / 9.0) + 32.0;
                    break;
                case "d":
                    result = temp + 273.15;
                    break;
                case "e":
                    result = (temp - 273.15) * (9.0 / 5.0) + 32.0;
                    break;
                case "f":
                    result = temp - 273.15;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
 }

