using System;

namespace array_metod
{
    class Program
    {
        static void Main(string[] args)
        { int num = 145;
            Console.WriteLine(NumLength(num));
        }
        static int NumLength(int num)
        {
            num = 145;
            int count = 0;
            while (num>0)
            {
                num /= 10;
                count++;
                   
            }
            return count;
        }
        
    }
}
