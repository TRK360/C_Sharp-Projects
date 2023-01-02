using System;
using System.Collections.Generic;
using System.Text;

namespace ThermalValueConverter
{
    public static class TemperatureConverter
    {
        public static double CelsiusToFahrenheit(string temperatureCelsius)
        {
            // Convert argument to double for calculations.
            double celsius = Double.Parse(temperatureCelsius);

            // Convert Celsius to Fahrenheit.
            double fahrenheit = (celsius * 9 / 5) + 32;

            return fahrenheit;
        }

        public static double FahrenheitToCelsius(string temperatureFahrenheit)
        {
            // Convert argument to double for calculations.
            double fahrenheit = Double.Parse(temperatureFahrenheit);

            // Convert Fahrenheit to Celsius.
            double celsius = (fahrenheit - 32) * 5 / 9;

            return celsius;
        }

        public static double MultipliedTemps(string fahrenheight)
        {
            // Convert argument to double for calculations.
            double fahrenheit100 = Double.Parse(Convert.ToString(fahrenheight+"00"));

            // Convert Fahrenheit to Celsius.
            double cnew = (fahrenheit100);

            return cnew;
        }


    }
}