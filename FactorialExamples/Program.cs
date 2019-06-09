using System;

namespace FactorialExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            uint factr;

            Console.Write("which number shoud be factorialized? : ");
            factr = Convert.ToUInt32 (Console.ReadLine());

            Console.WriteLine("Factorial using for loop: {0} ", Factorialize(factr));
            Console.WriteLine("Factorial using recursion: {0} ", FactorializeRecursion(factr));
            Console.Write("Factorial for each iteration: ");
            Console.WriteLine("Factorial using while: {0} ", FactorializeWhile(factr));
        }


        //----Solution 1 - using for loop----
        static ulong Factorialize(uint num)
        {
            ulong result = 1;
            for (uint i = num; i > 0; i--)
            {
                result *= i;
            }
            return result;
        }

        //----Solution 2 - using recursion----
       static ulong FactorializeRecursion(uint num)
        {
            if (num == 0)
            {
                return 1;
            }
            return num * FactorializeRecursion(num - 1);
        }

        //----Solution 3 - using while loop----
        static ulong FactorializeWhile(uint num)
        {
            ulong result = 1;
            while (num > 1)
            {
                result *= num;
                num -= 1;
                Console.Write("result = {0}  num = {1} | ", result, num);
            }
            Console.WriteLine(" ");
            return result;
            
        }
    }
}
