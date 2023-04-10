using Modul2HomeWork3.Enum;

namespace Modul2HomeWork3.Models
{
    public class Marmalade : SugarySweet
    {
        public MarmaladeType MarmaladeType { get; init; }

        public override void PrintFullInformation()
        {
            PrintName();
            Console.WriteLine($"Marmalade Type: {MarmaladeType}\tSugar: {SugarAmount}g");
        }
    }
}
