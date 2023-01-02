using System;

namespace ThermalValueConverter
{
    class TestTemperatureConverter
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("---Welcome to a thermal analysis program---");
        Console.WriteLine("Enter a value in Celsius to convert to Fahrenheit and more...");
        //Console.WriteLine("2. From Fahrenheit to Celsius.");
       

        string? selection = "1";
        double F, C, L= 0;

            Console.WriteLine("Please enter a numerical value of which you want to convert");

            string userTemp = Console.ReadLine();



        switch (selection)
        {
            case "1":
                F = TemperatureConverter.CelsiusToFahrenheit(userTemp ?? "0");
                Console.WriteLine("Temperature in Fahrenheit: {0:F2}", F);

                C = TemperatureConverter.FahrenheitToCelsius(userTemp ?? "0");
                Console.WriteLine("Temperature in Celsius (IF FAHRENHEIGHT ENTERED ERRONIOUSLY): {0:F2}", C);

                    L = TemperatureConverter.MultipliedTemps(userTemp ?? "0");
                    Console.WriteLine("Starting Temp times 100 equals:   {0:F2}", L);

                    break;

            default:
                Console.WriteLine("Please select a convertor.");
                break;
        }








        }
    }
}
