using Modul2HomeWork3.Models;

namespace Modul2HomeWork3
{
    public static class SweetSearcher
    {
        public static Sweet SearchByName(string name, Sweet[] array)
        {
            Sweet? result = null;

            foreach (var item in array)
            {
                if (item.Name == name)
                {
                    result = item;
                    break;
                }
            }

            return result;
        }
    }
}
