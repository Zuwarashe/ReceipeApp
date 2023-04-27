using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceipeApp
{
    internal class Structure
    {
        /*We will use our Structure class to take control of the arrays and the data stored in them
         * we have 7 declared public variables to use in the class
         * steps is an array soring all recipe steps in string format
         * ingredients is an array we will use to stores each indiviudal ingredient
         * units is our array that will store the unit of measure of each ingredient
         * quantities is an array to store the quantity of each ingredient
         * numIngredients stores the number of ingredients used
         * numSteps stores the number of steps that the recipe will use
         * original is used to keep trcak of the scaling range so that we can convert back to original quantites later
         */
        private string[] steps;
        private string[] ingredients;
        private string[] units;
        private double[] quantities;
        private int numIngredients;
        private int numSteps;
        private double original;
        public void NewRecipe()
        {
            Console.WriteLine("Lets make a new recipe !");
            Console.Write("Enter the number of ingredients: ");
            numIngredients = int.Parse(Console.ReadLine());

             ingredients = new string[numIngredients];
             quantities = new double[numIngredients];
             units = new string[numIngredients];

            for (int i = 0; i < numIngredients; i++)
            {
                Console.Write($"Enter the name of ingredient {i + 1}: ");
                ingredients[i] = Console.ReadLine();

                Console.Write("Enter the quantity: ");
                quantities[i] = double.Parse(Console.ReadLine());

                Console.Write("Enter the unit of measurement: ");
                units[i] = Console.ReadLine();
            }

            Console.Write("Enter the number of steps: ");
            numSteps = int.Parse(Console.ReadLine());

            steps = new string[numSteps];

            for (int i = 0; i < numSteps; i++)
            {
                Console.Write($"Enter step {i + 1}: ");
                steps[i] = Console.ReadLine();
            }
        }
       
        public void ShowRecipe()
        {
            Console.WriteLine("*--*--*--*--*--*--*--*--*--*--*--*--*--*");
            Console.WriteLine("Here is your recipe:");
            Console.WriteLine("----------------------------------------");

            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"{quantities[i]} {units[i]} of {ingredients[i]}");
            }

            Console.WriteLine("---------------------------------------");

            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"{i + 1}. {steps[i]}");
            }

            Console.WriteLine("*--*--*--*--*--*--*--*--*--*--*--*--*--*");
            Console.WriteLine("Enjoy your meal!");
        }

        public void ScaleRecipe(double scale)
        {
            original = scale;
            Console.WriteLine("*--*--*--*--*--*--*--*--*--*--*--*--*--*");
            Console.WriteLine("Here is your scaled recipe:");
            Console.WriteLine("----------------------------------------");
            for (int i = 0; i < numIngredients; i++)
            {
                quantities[i] = quantities[i] * scale;
            }

                for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"{quantities[i]} {units[i]} of {ingredients[i]}");
            }

            Console.WriteLine("----------------------------------------");

            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"{i + 1}. {steps[i]}");
            }

            Console.WriteLine("*--*--*--*--*--*--*--*--*--*--*--*--*--*");
            Console.WriteLine("Enjoy your meal!");
        }

        public void Original()
        {
            for (int i = 0; i < numIngredients; i++)
            {
                quantities[i] = quantities[i] / original;
            }

            ShowRecipe();
        }

        public void Reset()
        {
            ingredients = new string[0];
            quantities = new double[0];
            units = new string[0];
            steps = new string[0];
            numIngredients = 0;
            numSteps = 0;
        }
    }
}
