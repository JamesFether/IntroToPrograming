using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challage_One_Roll_the_Dice
{
    class Program
    {
        static void Main(string[] args)
        {

            string again = "yes";
            while (again == "yes")

            {
                Console.WriteLine(string.Concat(Enumerable.Repeat("-", Console.BufferWidth - 1)));
                Console.WriteLine("Hey! Lets play a game!");
                Console.WriteLine("Roll the Dice");

                String user = Console.ReadLine();

                Random r = new Random();
                int user1 = r.Next(3);


                if (user1 == 1)
                {
                    if (user == "Rolls")
                    {
                        Console.WriteLine("The User Rolled the dice");
                        Console.WriteLine("Its a 1!");
                    }

                }
            }

        }
    }

}