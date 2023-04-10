using Modul2HomeWork3.Enum;

namespace Modul2HomeWork3.Models
{
    public class Waffle : FlourSweet
    {
        public WaffleType WaffleType { get; init; }

        public override void PrintFullInformation()
        {
            PrintName();
            Console.WriteLine($"Waffle Type: {WaffleType}\tFlour Type: {FlourType}");
        }
    }
}
