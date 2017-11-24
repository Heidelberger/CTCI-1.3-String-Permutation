using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI_1._3_String_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "Sesquipedalian";
            string string2 = "quail";
            string string3 = "Xerox";
            string string4 = "pedal";

            contains_dotnet(string1, string2);
            contains_dotnet(string1, string3);
            contains_dotnet(string1, string4);

            Console.ReadLine();
        }

        private static void contains_dotnet(string string1, string string2)
        {
            //double the string to allow for any "rotation" problems in the order of characters
            string1 += string1;

            if (string1.Contains(string2))
                Console.WriteLine(".NET: " + string1 + " contains " + string2);
            else
                Console.WriteLine(".NET: " + string1 + " does not contain " + string2);
        }
    }
}
