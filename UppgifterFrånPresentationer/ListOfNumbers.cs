using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppgifterFrånPresentationer
{
    public static class ListOfNumbers
    {

        public static void Divide()
        {
            List<int> funListNumbers = new List<int>();           
            for (int i= 0; i <= 30;i++)
            {
                funListNumbers.Add(i + 1);
            }

            int[] numbers = funListNumbers.ToArray();

            Console.WriteLine("Without LINQ:");
            foreach (var e in numbers)
            {
                if (e%3==0||e%7==0)
                {
                    Console.WriteLine(e);
                }
            }

            Console.WriteLine("With LINQ:");
            var result = from num in numbers where num % 3 == 0 || num % 7 == 0 select num;
            foreach (var e in result)
            {
                Console.WriteLine(e);
            }


            Console.WriteLine("----------------------------------------------------");
        }
    }
}
