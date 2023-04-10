using Modul2HomeWork3.Enum;

namespace Modul2HomeWork3.Models
{
    public class Chocolate : SugarySweet
    {
        public ChocolateType ChocolateType { get; init; }

        public override void PrintFullInformation()
        {
            PrintName();
            Console.WriteLine($"Chocolate Type: {ChocolateType}\tSugar: {SugarAmount}g");
        }
    }
}
