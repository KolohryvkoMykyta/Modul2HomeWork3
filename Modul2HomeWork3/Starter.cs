using Modul2HomeWork3.Models;

namespace Modul2HomeWork3
{
    public static class Starter
    {
        public static void Run()
        {
            Gift gift = GiftCreator.CreateGift(GiftCreator.SelectionSize());
            gift.Print();

            Console.Write("\nEnter the name of the sweet to find out the full information about it: ");

            while (true)
            {
                string sweetName = Console.ReadLine();
                Sweet foundSweet = SweetSearcher.SearchByName(sweetName, gift.Sweets);

                if (foundSweet != null)
                {
                    Console.WriteLine("\nComplete information about the selected sweet:\n");
                    foundSweet.PrintFullInformation();
                    break;
                }
                else
                {
                    Console.WriteLine("\nNo such sweetness found!");
                    Console.Write("Try again: ");
                }
            }

            Console.ReadKey();
        }

    }
}
