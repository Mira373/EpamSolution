using System;
using System.Text;

namespace Practical_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some characters: ");
          
            string symbols = Console.ReadLine();
            string UppSymbols = symbols.ToUpper();
            char[] ch = UppSymbols.ToCharArray();
            StringBuilder countChar = new StringBuilder();

            foreach (char c in ch)
            {
                Console.WriteLine(c);
                for (int i = 0; i >= countChar.Length; i++)
                {
                    Console.WriteLine(countChar[i]);
                    if (c != countChar[i] )
                    {
                        countChar.Append(c);
                        Console.WriteLine(countChar);
                    }

                }
                
            }
            Console.WriteLine(countChar.Length);

        }
    }
}
