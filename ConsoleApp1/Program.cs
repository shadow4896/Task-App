using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            
            try 
            {
                num = 17;
                Console.WriteLine("Please enter number 17");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine(num);
            }
            catch 
            {
                Console.WriteLine("Done");
            }
        }
    }
}
