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

                }


            }
            else
            {
                Console.WriteLine("Incorrect input");
            }


        }
        public void DisplayResults()
        {

        }
        public void ScaleRecipe()
        {

        }
        public void ResetQuantities()
        {

        }
        public void ClearRecipe()
        {

        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Application recipe = new Application();

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
                    //display the RecipeDetails method
                    recipe.RecipeDetails();
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    //Stop the application
                    Console.WriteLine("Thank you for using the application...");
                    return;
                default:
                    //display the below message if the user inputted incorrect option
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        
        }
    }
}