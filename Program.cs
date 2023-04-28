using Part1;
using System;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

namespace Part1
{
    class Application
    {
        private string[] ingredients;
        private double[] quantities;
        private string[] units;
        private string[] steps;

        String recipeName;
        double n;
        public Application()
        {
            // Initialize empty arrays for ingredients, quantities, units, and steps
            ingredients = new string[0];
            quantities = new double[0];
            units = new string[0];
            steps = new string[0];
        }
        public void RecipeDetails()
        {
            //Prompt the user to enter the recipe name
            Console.Write($"Enter the name of recipe: ");
            recipeName = Console.ReadLine();

            //Prompt the user to enter the number of ingredients he will need
            Console.Write("Enter the number of ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());

            if (numIngredients > 0) //if numIngredients is less than or equal to zero the program will stop
            {
                // Initialize the below arrays with the correct size
                ingredients = new string[numIngredients];
                quantities = new double[numIngredients];
                units = new string[numIngredients];

                int count = 1;

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

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Invalid input. Please try again");
                        Console.Write("Ingredient quantity: ");
                    }

                    ///Prompt the user to choose from the below units values
                    Console.WriteLine("Select the units of measurements (mg),(g),(kg),(ml),(l),(tablespoon),(teaspoon),(cups)");
                    units[a] = Console.ReadLine();
                    Boolean ingredientUnits = true;

                    while (ingredientUnits)//loop that make ensure you inputted correct units 
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
                        else if (units[a].Equals("tablespoon"))
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
                    count++;

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
                    }
                }


            }
            else
            {
                Console.WriteLine("Incorrect input");
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
                Console.WriteLine($"Step {b + 1}  {steps[b]}");
            }
        }
    }
        
    
}