namespace Modul2HomeWork3.Models
{
    public abstract class Sweet : IComparable
    {
        public string? Name { get; init; }
        public string? ManufacturerName { get; init; }
        public int Weight { get; init; }
        public void PrintName()
        {
            Console.WriteLine($"Name: '{Name}'\tManufacturer: '{ManufacturerName}'\tWeight: {Weight}g");
        }

        public abstract void PrintFullInformation();

        public int CompareTo(object? obj)
        {
            return Weight.CompareTo(((Sweet)obj).Weight);
        }
    }
}
