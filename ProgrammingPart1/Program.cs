using ProgrammingPart1;

public class Program
{
    private static void Main(string[] args)
    {
        Recipe recipe = new Recipe();
        while (true)
        {
            Console.WriteLine(" welcome to my recipe app");
            Console.WriteLine("1. create a recipe");
            Console.WriteLine("2. display recipe");
            Console.WriteLine("3. scale recipe");
            Console.WriteLine("4. reset quantities");
            Console.WriteLine("5. clear recipe");
            Console.WriteLine("6. exit");

            Console.WriteLine("enter any option:");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    recipe.InsertIngredients();
                    break;
                    case 2:
                    recipe.DisplayRecipe();
                    break;
                    case 3:
                    Console.WriteLine("enter scale factor (0.5, 2, or 3): ");
                    double factor = double.Parse(Console.ReadLine());
                    recipe.ScaleRecipe(factor);
                    break;
                    case 4:
                    recipe.ResetQuantities();
                    break;
                    case 5:
                    recipe.ClearRecipe();
                    recipe = new Recipe();
                    break;
                    case 6:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("invalid choice selected");
                    break;
            }
        }
    }
    static int Readint(string prompt)
    {
        while (true)
        {
            Console.WriteLine(prompt);
            if(int.TryParse(Console.ReadLine(),out int result))
            {
                return result;
            }
            Console.WriteLine("invalid input.please enter an integer");
        }
    }
    static double Readdouble(string prompt)
    {
        while (true)
        {
            Console.WriteLine(prompt);
            if(double.TryParse(Console.ReadLine(),out double result))
            {
                return result;
            }
            Console.WriteLine("invalid input.please enter a number");
        }
    }
}
        

