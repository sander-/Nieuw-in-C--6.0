using System.Convert;
using StaticMembers.TemperatuurConversie;

namespace StaticMembers
{
    static class TemperatuurConversie
    {
        public static double ToFahrenheit(double celsius)
        {
            return celsius * 1.8 + 32;
        }
        public static double ToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) / 1.8;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var vandaag = ToDateTime("2014-12-01");
            var graden = ToCelsius(76);
        }
    }
}
