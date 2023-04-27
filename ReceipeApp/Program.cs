using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceipeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Structure calling = new Structure();
            Boolean running = true;
            while (running)
            {
                Console.Write("");
                Console.WriteLine("Welcome to your recipe App!!");
                Console.WriteLine("Enter '1' to enter recipe");
                Console.WriteLine("Enter '2' to display your recipe");
                Console.WriteLine("Enter '3' to scale your recipe");
                Console.WriteLine("Enter '4' to reset recipe quantities");
                Console.WriteLine("Enter '5' to clear recipe");
                Console.WriteLine("Enter '6' to exit");

                string option = Console.ReadLine();
                

                switch (option)
                {
                    case "1":
                        calling.NewRecipe();
                        break;
                    case "2":
                        calling.ShowRecipe();
                        break;
                    case "3":
                        Console.Write("Enter scaling factor (0.5, 2, or 3): ");
                        double scale = double.Parse(Console.ReadLine());
                         if(scale== 0.5 || scale==2 || scale == 3)
                              {
                                calling.ScaleRecipe(scale);
                              }
                        else
                              {
                                   Console.WriteLine("Ïnvalid scaling number");
                              }
                        break;
                    case "4":
                        calling.Original();
                        break;
                    case "5":
                        calling.Reset();
                        break;
                    case "6":
                        Console.WriteLine("Exiting program...");
                        running = false;
                        return;
                    default:
                        Console.WriteLine("Invalid choice,Please enter a valid choice. :)");
                        break;
                }

            }
        }
    }
}

