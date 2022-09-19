using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sentence reversing
            Console.WriteLine("Enter you sentence eg hello world");
            string sentence = Console.ReadLine();
            var split = sentence.Split(' ');
            StringBuilder sb = new StringBuilder();

            for (int i = split.Length - 1; i >= 0; i--)
            {
                sb.Append(split[i] + " ");
            }
            Console.WriteLine("Reversed Sentence");
            Console.WriteLine(sb.ToString());
            //Console.ReadLine();

            //multiples of 3 or 5 less than 1000
            int sum = 0;
            for( int i = 3; i < 1000; i++)
            {
                if(i%3 == 0 || i%5==0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("The sum of multiples of 3 or 5 is " + sum);
            //Console.ReadLine();

           
            //Prime numbers
            int count = 0;
            int lastprime = 2;

            while (count <= 10001)
            {
                if (IsPrime(lastprime))
                {
                    count++;
                }

                lastprime++;
            }

            Console.WriteLine("The 10001st prime number is " + (lastprime - 1));
            //Console.ReadLine();

            //Fibonacci
            int fiboosum = 4000000;
            int currentvalue = 0;
            int previousNumber = 0;
            int currentNumber = 1;
            int nextNumber = 0;
            int evenfibonacciSums = 0;


            while (currentvalue < fiboosum)
            {
                //Console.Write(" {0}", nextNumber);
                nextNumber = previousNumber + currentNumber;
                previousNumber = currentNumber;
                currentNumber = nextNumber;

                //keep track of the total value
                currentvalue = currentvalue + currentNumber;

                //keep track of the even fibonnacii numbers
                if(currentNumber % 2 == 0)
                {
                    evenfibonacciSums = evenfibonacciSums + currentNumber;
                }
            }
            Console.WriteLine();
            Console.WriteLine("The sum of the even Fibonnacci terms is " + evenfibonacciSums);
            Console.ReadLine();
        }

        private static bool IsPrime(int num)
        {
            bool isprime = true;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isprime = false;
                }
            }

            return isprime;

        }
    }
}
