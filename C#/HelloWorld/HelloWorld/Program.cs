using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Я хочу изучать С#");
            //Console.ReadLine();

            String a = Console.ReadLine();
            String b = Console.ReadLine();

            int num1 = Int32.Parse(a);
            int num2 = Int32.Parse(b);

            int result = num1 + num2;
            Console.WriteLine(result);
            result = num1 * num2;
            Console.WriteLine(result);

            double average = (num1 + num2) / 2;
            Console.WriteLine(average);

            Console.ReadLine();
        }
    }
}
