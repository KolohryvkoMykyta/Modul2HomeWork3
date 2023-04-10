using Modul2HomeWork3.Enum;
using Modul2HomeWork3.Models;

namespace Modul2HomeWork3
{
    public static class ListOfSweets
    {
        public static Sweet[] AllSweets { get; } = new Sweet[]
        {
            new Candy() { Name = "Bim Bom", ManufacturerName = "Roshen", CandyType = CandyType.Cane, SugarAmount = 60, Weight = 75 },
            new Candy() { Name = "Barbaris", ManufacturerName = "Roshen", CandyType = CandyType.Caramel, SugarAmount = 66, Weight = 100 },
            new Candy() { Name = "Pismaniye", ManufacturerName = "Hayali", CandyType = CandyType.Chocolate, SugarAmount = 73, Weight = 150 },
            new Chocolate() { Name = "Bruit", ManufacturerName = "Roshen", ChocolateType = ChocolateType.Black, SugarAmount = 23, Weight = 85 },
            new Chocolate() { Name = "Very Pery", ManufacturerName = "Millenium", ChocolateType = ChocolateType.Milk, SugarAmount = 33, Weight = 90 },
            new Chocolate() { Name = "Koros & Hares", ManufacturerName = "Xucher", ChocolateType = ChocolateType.White, SugarAmount = 41, Weight = 100 },
            new Cookie() { Name = "Multi Cake", ManufacturerName = "Roshen", CookiesType = CookiesType.Butter, FlourType = FlourType.Wheat, Weight = 75 },
            new Cookie() { Name = "Cracker", ManufacturerName = "Yarych", CookiesType = CookiesType.Cracker, FlourType = FlourType.Rice, Weight = 135 },
            new Cupcake() { Name = "Casa Rinaldi", ManufacturerName = "ABK", CupcakeType = CupcakeType.English, FlourType = FlourType.Wheat, Weight = 125 },
            new Cupcake() { Name = "Panettone", ManufacturerName = "ABK", CupcakeType = CupcakeType.French, FlourType = FlourType.Wheat, Weight = 130 },
            new Cupcake() { Name = "Fruhlings Stollen", ManufacturerName = "ABK", CupcakeType = CupcakeType.German, FlourType = FlourType.Wheat, Weight = 120 },
            new Marmalade() { Name = "Trolli Twist", ManufacturerName = "Trolli", MarmaladeType = MarmaladeType.FruitAndBerry, SugarAmount = 60, Weight = 110 },
            new Marmalade() { Name = "Kids Box", ManufacturerName = "Trolli", MarmaladeType = MarmaladeType.Jelly, SugarAmount = 58, Weight = 115 },
            new Marmalade() { Name = "Bob", ManufacturerName = "Trolli", MarmaladeType = MarmaladeType.JellyFruit, SugarAmount = 52, Weight = 105 },
            new Waffle() { Name = "Manner", ManufacturerName = "Nestle", WaffleType = WaffleType.Belgian, FlourType = FlourType.Rice, Weight = 165 },
            new Waffle() { Name = "Wafer", ManufacturerName = "Nestle", WaffleType = WaffleType.Viennese, FlourType = FlourType.Buckwheat, Weight = 140 },
        };
    }
}