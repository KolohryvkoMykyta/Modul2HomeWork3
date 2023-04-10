using Modul2HomeWork3.Enum;

namespace Modul2HomeWork3.Models
{
    public class Cookie : FlourSweet
    {
        public CookiesType CookiesType { get; init; }

        public override void PrintFullInformation()
        {
            PrintName();
            Console.WriteLine($"Cookies Type: {CookiesType}\tFlour Type: {FlourType}");
        }
    }
}
