using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1_Homework
{
    class FruitLoop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fruit Loops");

            string[] fruit = {"apple", "banana", "orange", "lemon", "lime", "blueberry"};
            string dots = "";

            for (int i = 0; i < fruit.Length; i++)
            {
                if (i != 0)
                {
                    dots += ".";
                }
            Console.WriteLine(fruit[i]);
            Console.WriteLine(dots);
            }
           
        }
    }
}
