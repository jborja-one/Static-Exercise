namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a temperature in Celsius:");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = TempConverter.CelsiusToFahrenheit(celsius);
            Console.WriteLine($"{celsius}°C is equal to {fahrenheit}°F");

            Console.WriteLine("Enter a temperature in Fahrenheit:");
            double fahrenheitInput = double.Parse(Console.ReadLine());

            double celsiusOutput = TempConverter.FahrenheitToCelsius(fahrenheitInput);
            Console.WriteLine($"{fahrenheitInput}°F is equal to {celsiusOutput}°C");
        }
    }
}
