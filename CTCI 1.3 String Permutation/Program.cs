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
            PrintHeaderMsg(1, 3, "String Permutation");

            string string1 = "sesquipedalian";
            string string2 = "quail";
            string string3 = "xerox";
            string string4 = "pedal";
            string string5 = "pedaliansesqui";

            contains_dotnet(string1, string2);
            contains_dotnet(string1, string3);
            contains_dotnet(string1, string4);
            contains_dotnet(string1, string5);

            Console.WriteLine();

            permutation_dotnet(string1, string2);
            permutation_dotnet(string1, string3);
            permutation_dotnet(string1, string4);
            permutation_dotnet(string1, string5);

            Console.ReadLine();
        }

        private static void permutation_dotnet(string passed_string1, string passed_string2)
        {
            if (passed_string1.Length == passed_string2.Length)
            {
                string temp = passed_string1 + passed_string1; // solves "word wrap" problem

                if (temp.Contains(passed_string2))
                {
                    Console.WriteLine(passed_string1 + " is a permutation of " + passed_string2);
                    return;
                }
            }

            Console.WriteLine(passed_string1 + " is not a permutation of " + passed_string2);            
        }

        private static void contains_dotnet(string string1, string string2)
        {
            //double the string to allow for any "rotation" problems in the order of characters
            string1 += string1;

            if (string1.Contains(string2))
                Console.WriteLine(string1 + " contains " + string2);
            else
                Console.WriteLine(string1 + " does not contain " + string2);
        }

        private static void PrintHeaderMsg(int chapter, int problem, string title)
        {
            Console.WriteLine("Cracking the Coding Interview");
            Console.WriteLine("Chapter " + chapter + ", Problem " + chapter + "." + problem + ": " + title);            
            Console.WriteLine();
        }
    }
}
