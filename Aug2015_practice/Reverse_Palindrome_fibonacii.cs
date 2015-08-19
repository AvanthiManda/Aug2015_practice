using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug2015_practice
{
    public class Reverse_Palindrome_fibonacii
    {
        public static void Main()
        {
            Reverse_Palindrome_fibonacii prog = new Reverse_Palindrome_fibonacii();
            string print = prog.reverseString("Avanthi");
            Console.WriteLine(print);
            prog.fizzBuzz();
            Console.ReadLine();           
        }
        public string reverseString(string name)
        {
            string output = "";
            for (int i = name.Length -1 ; i >= 0; i--)
            {
                output = output + name[i];
            }
            return output;
        }
        // FizzBizz comment
        public int fizzBuzz()
        {
            int output = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("FIZZBUZZ");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("FIZZ");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("BUZZ");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            return output;
        }
    }

}
