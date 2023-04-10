using Modul2HomeWork3.Enum;

namespace Modul2HomeWork3.Models
{
    public class Cupcake : FlourSweet
    {
        public CupcakeType CupcakeType { get; init; }

        public override void PrintFullInformation()
        {
            PrintName();
            Console.WriteLine($"Cupcake Type: {CupcakeType}\tFlour Type: {FlourType}");
        }
    }
}
