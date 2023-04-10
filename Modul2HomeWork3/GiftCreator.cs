using Modul2HomeWork3.Models;

namespace Modul2HomeWork3
{
    public static class GiftCreator
    {
        public static Gift CreateGift(int sweetsAmount)
        {
            Gift gift = new Gift();
            var random = new Random();

            for (int i = 0; i < sweetsAmount; i++)
            {
                gift.Add(ListOfSweets.AllSweets[random.Next(ListOfSweets.AllSweets.Length)]);
            }

            Array.Sort(gift.Sweets);

            return gift;
        }

        public static int SelectionSize()
        {
            Console.WriteLine("Choose gift size: (press 1,2 or 3)\n1 Small\n2 Average\n3 Big");
            while (true)
            {
                char choice = Console.ReadKey(true).KeyChar;
                if (choice == '1')
                {
                    return 5;
                }
                else if (choice == '2')
                {
                    return 10;
                }
                else if (choice == '3')
                {
                    return 15;
                }
                else
                {
                    Console.WriteLine("Invalid input! Try again!");
                }
            }
        }
    }
}
