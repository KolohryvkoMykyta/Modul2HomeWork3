using Modul2HomeWork3.Enum;

namespace Modul2HomeWork3.Models
{
    public class Candy : SugarySweet
    {
        public CandyType CandyType { get; init; }

        public override void PrintFullInformation()
        {
            PrintName();
            Console.WriteLine($"Candy Type: {CandyType}\tSugar: {SugarAmount}g");
        }
    }
}
