using Part1;
using System;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

namespace Part1
{
    class Recipe
    {
        private string[] ingredients;
        private double[] quantities;
        private string[] units;
        private string[] steps;

        String recipeName;
        double n;
        public Recipe()
        {
            // Initialize empty arrays for ingredients, quantities, units, and steps
            ingredients = new string[0];
            quantities = new double[0];
            units = new string[0];
            steps = new string[0];
         }
        public void RecipeDetails()
        {      
                Console.Write($"Enter the name of recipe: ");
                recipeName = Console.ReadLine();
            
            Console.Write("Enter the number of ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());
            if(numIngredients > 0)
            {
                // Initialize the below arrays with the correct size
                ingredients = new string[numIngredients];
                quantities = new double[numIngredients];
                units = new string[numIngredients];
                int j = 1;
                // Prompt the user to enter the details for each ingredient
                for (int a = 0; a < numIngredients; a++)
                {
                    Console.WriteLine($"Enter details for ingredient #{a + 1}:");

                    Boolean w = true;

                    Console.Write("Ingredient name: ");
                    ingredients[a] = Console.ReadLine();
                    try
                    {
                        Console.Write("Ingredient quantity: ");
                        quantities[a] = double.Parse(Console.ReadLine());
                       // break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Invalid input. Please try again");
                    }

                    Console.WriteLine("Select the units of measurements (mg),(g),(kg),(ml),(l),(teaspoon),(cups)");//user must enter Quantity units
                    units[a] = Console.ReadLine();
                    Boolean n = true;
                    while (n)//loop that ensures that the user inputs the right units 
                    {
                        if (units[a].Equals("mg"))
                        {
                            break;
                        }
                        else if (units[a].Equals("g"))
                        {
                            break;
                        }
                        else if (units[a].Equals("kg"))
                        {
                            break;
                        }
                        else if (units[a].Equals("ml"))
                        {
                            break;
                        }
                        else if (units[a].Equals("l"))
                        {
                            break;
                        }
                        else if (units[a].Equals("teaspoon"))
                        {
                            break;
                        }
                        else if (units[a].Equals("cups"))
                        {
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Incorrect units of measurement. Please try again");
                            Console.WriteLine("Select the units of measurements (mg),(g),(kg),(ml),(l),(teaspoon),(cups)");
                            units[a] = Console.ReadLine();
                        }


                    }
                    j++;
                }

                // Prompt the user to enter the number of steps
                Console.Write("Enter the number of steps: ");
                int numSteps = int.Parse(Console.ReadLine());

                // Initialize the steps array with the correct size
                steps = new string[numSteps];

                // Prompt the user to enter the details for each step
                for (int b = 0; b < numSteps; b++)
                {

                    Console.Write($"Enter step #{b + 1}: ");
                    steps[b] = Console.ReadLine();
                    //     }
                    //  }
                }
            }

                   
        }
        public void DisplayResults()
        {
            if (ingredients.Length > 0)
            {
                Console.WriteLine("Recipe name: " + recipeName);
            }
            else { Console.WriteLine("There's no recipe saved "); }


            // Display the ingredients and quantities results
            Console.WriteLine("Ingredients: ");
                for (int a = 0; a < ingredients.Length; a++)
                {
                    Console.WriteLine($"- {quantities[a]} {units[a]} of {ingredients[a]}");
                }

                // Display the steps results
                Console.WriteLine("Steps: ");
            for (int b = 0; b < steps.Length; b++)
            {
                Console.WriteLine($"- {steps[b]}\n");
            }         
        }
        public void ScaleRecipe()
        {
            // Multiply all the quantities by the scaling factor
            /*for (int i = 0; i < quantities.Length; i++) {
                quantities[i] *= factor;
            }*/

            //Console.WriteLine("Choose the factor that you would like ingredients to be affected with: \n 1-0.5(half) \n2-2(double) \n3- 3(triple) \n");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantities.Length; i++)
            {
                if (quantities[i] == 8 || units[i].Equals("teaspoon") || n == 2)
                {
                    quantities[i] = 1;
                    units[i] = "cups";
                }
                else if (n == 1)
                {
                    quantities[i] *= 0.5;
                }
                else
                {
                    quantities[i] *= n;
                }
            }
        }
        public void ResetQuantities()
        {
            // Reset all the quantities to their original values
            for (int i = 0; i < quantities.Length; i++) 
            {
                //quantities[i] /= factor;
                if (n == 1)
                {
                    quantities[i] /= 0.5;
                    //Console.WriteLine(" Quantity changed ");
                }
                else
                {
                    quantities[i] /= n;
                    //Console.WriteLine(" Quantity changed ");
                }

            }


        }
        public void ClearRecipe()
        {
            // Reset all the arrays to empty
            ingredients = new string[0];
            quantities = new double[0];
            units = new string[0];
            steps = new string[0];
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Recipe recipe = new Recipe();

        // Set the Foreground color to Cyan
        Console.ForegroundColor
            = ConsoleColor.Cyan;

        Console.WriteLine("*******Welcome to Destoyer's Application*******");

        while (true)
        {
            Console.WriteLine("1. Recipe details");
            Console.WriteLine("2. Display recipe");
            Console.WriteLine("3. Scale recipe");
            Console.WriteLine("4. Reset quantities");
            Console.WriteLine("5. Clear recipe");
            Console.WriteLine("6. Exit");

            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    recipe.RecipeDetails();
                    break;
                case "2":
                    recipe.DisplayResults();
                    break;
                case "3":
                    Console.WriteLine("Choose the factor that you would like ingredients to be affected with: \n 1-0.5(half) \n2-2(double) \n3- 3(triple) \n");
                    //Console.Write("Enter scaling factor (0.5, 2, or 3): ");
                    /* double factor1 = double.Parse(Console.ReadLine());*/
                    recipe.ScaleRecipe();
                    break;
                case "4":
                    recipe.ResetQuantities();
                    break;
                case "5":
                    recipe.ClearRecipe();
                    break;
                case "6":
                    Console.WriteLine("Thank you for using the application...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        
        }
    }
}