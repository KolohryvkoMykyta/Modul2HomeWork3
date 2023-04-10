namespace Modul2HomeWork3.Models
{
    public class Gift
    {
        public Sweet[] Sweets { get; private set; } = new Sweet[0];
        public int TotalWeight { get; private set; } = 0;

        public void Add(Sweet sweet)
        {
            var temp = new Sweet[Sweets.Length + 1];

            for (int i = 0; i < Sweets.Length; i++)
            {
                temp[i] = Sweets[i];
            }

            temp[temp.Length - 1] = sweet;
            Sweets = temp;
            TotalWeight += sweet.Weight;
        }

        public void Print()
        {
            Console.WriteLine("\n\tList of sweets:\n");

            for (int i = 0; i < Sweets.Length; i++)
            {
                Sweets[i].PrintName();
            }
        }
    }
}
