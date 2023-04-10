using System.Runtime.CompilerServices;

namespace Modul2HomeWork3.Models
{
    public static class GiftExtension
    {
        public static Sweet SearchByName(this Gift gift, string name)
        {
            Sweet? result = null;

            foreach (var item in gift.Sweets)
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
