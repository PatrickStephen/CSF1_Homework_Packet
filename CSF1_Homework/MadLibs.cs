using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1_Homework
{
    class MadLibs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Winter in New England: Mad Libs");
            Console.WriteLine();

            string adjective, place, shadeOfGrey, stateOfWater, food, drink;
            Console.Write("Enter a adjective... ");
            adjective = Console.ReadLine();

            Console.Write("Enter a place... ");
            place = Console.ReadLine();

            Console.Write("Enter a shade of grey... ");
            shadeOfGrey = Console.ReadLine();

            Console.Write("Enter a state of water, ex:ice, snow, or rain... ");
            stateOfWater = Console.ReadLine();

            Console.Write("Enter a food... ");
            food = Console.ReadLine();

            Console.Write("Enter a drink... ");
            drink = Console.ReadLine();

            Console.WriteLine("It's been a " + adjective + 
                " winter her in " + place + 
                ". For as long as we can remember, the sky has been a shade of " + shadeOfGrey +
                " and the ground has been covered with " + stateOfWater +
                ". We have all been surviving on a steady diet of " + food + 
                " and " + drink + ".");

            Console.WriteLine();
        }
    }
}
