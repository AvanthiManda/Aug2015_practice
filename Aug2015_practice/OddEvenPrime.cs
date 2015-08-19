using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug2015_practice
{
   public class OddEvenPrime
    {
       /// <summary>
       /// to print odd,even and prime using switch case
       /// </summary>
       /// <param name="args"></param>
       /* static void Main(string[] args)
        {
            Console.WriteLine("Choose a program to compute 1. EVEN  2.ODD 3.PRIME");
            int input = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please enter a number");
            int num = Convert.ToInt16(Console.ReadLine());
            OddEvenPrime prog = new OddEvenPrime();
            bool output = false ;

            switch (input)
            {
                case 1:
                    output = prog.isEven(num);
                    break;
                case 2:
                    output = prog.isOdd(num);
                    break;
                case 3:
                    output = prog.isPrime(num);
                    break;
                default:
                    break;
            }            
            Console.WriteLine(output);
            Console.ReadLine();
        } */
        public bool isEven(int num)
        {
            bool result = false;
            if (num % 2 == 0)
            {
                result = true;
            }
            return result;
        }
        public bool isOdd(int num)
        {
            bool result = false;
            if (num % 2 != 0)
            {
                result = true;
            }
            return result;
        }
        public bool isPrime(int num)
        {
            bool result = true;
            for(int i =2; i * i <= num ; i++)
            {
                if (num % i == 0)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
    }
}
