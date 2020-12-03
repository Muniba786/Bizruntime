using System;

namespace ConsoleApp6
{
    class EnumEx
    {
        public enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

        public static void Main()
        {
            foreach (string s in Enum.GetNames(typeof(Days)))
            {
                Console.WriteLine(s);
            }
            foreach (Days d in Enum.GetValues(typeof(Days)))
            {
                //Console.WriteLine(d);
            }
        }
    }
}
