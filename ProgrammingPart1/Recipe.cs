using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPart1
{
    public class Recipe
    {
        //define arrays for steps and ingredients
        private Ingredients[] ingredients;
        private string[] steps;
        private const int MAXINGREDIENTS = 10;
        private const int MAXSTEPS = 10;

        public Recipe()
        {
            ingredients = new Ingredients[MAXINGREDIENTS];
            steps = new string[MAXSTEPS];
        }

        public void InsertIngredients()
        {
            //get the amount of ingredients 
            Console.WriteLine("enter the amount of ingredients needed: ");
            int AmountIngredients = int.Parse(Console.ReadLine());

            for (int i = 0; i < AmountIngredients; i++)
            {
                //prompt user for name, quantity and unit
                Console.WriteLine($"enter the names of ingredients needed #{i + 1}:");
                string name = Console.ReadLine();
                Console.WriteLine("quantity:");
                double quantity1 = double.Parse(Console.ReadLine());
                Console.WriteLine("unit of measurement:");
                String unit = Console.ReadLine();

                ingredients[i] = new Ingredients { name = name, quantity = quantity1, Unit = unit };
            }
        }
        public void InsertSteps()
        {
            //get number of steps
            Console.WriteLine("insert the number of steps: ");
            int amountSteps = int.Parse(Console.ReadLine());

            for (int i = 0; i < amountSteps; i++)
            {
                Console.WriteLine($"enter the step #{i + 1}: ");
                steps[i] = Console.ReadLine();
            }
        }
        public void DisplayRecipe()
        {
            //display the recipe to user
            Console.WriteLine("Ingredients:");

            foreach (Ingredients ingredients in ingredients)
            {
                if (ingredients == null)
                    break;
                Console.WriteLine($"{ingredients.quantity} {ingredients.Unit} of {ingredients.name}");
            }
            Console.WriteLine("steps:");

            foreach (string step in steps)
            {
                if (step == null)
                    break;
                Console.WriteLine($"{step}");
            }

        }
        public void ScaleRecipe(double factor)
        {
            //prompt the user to scale the recipe
            foreach (Ingredients ingredients in ingredients)
            {
                if (ingredients == null)
                    break;
                ingredients.quantity *= factor;
            }
        }
        public void ResetQuantities()
        {
            //reset the ingredients quantities
            foreach (Ingredients ingredients in ingredients)
            {
                if (ingredients == null)
                    break;
                ingredients.quantity *= ingredients.quantity / ingredients.quantity;
            }
        }
        public void ClearRecipe()
        {
            //clear the recipe
            Array.Clear(ingredients, 0, ingredients.Length);
            Array.Clear(steps, 0, steps.Length);
        }
    }

}
