using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyMyShoppingListFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\...\Samples\MyShoppimgList";
            string fileName = @"\\MyshoppingList.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> MyShoppingList = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Would you like to add a shopping item Y/N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Enter you shopping item:");
                    string userShoppingItem = Console.ReadLine();
                    MyShoppingList.Add(userShoppingItem);

                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Take care!");
                }
            }
            Console.Clear();

            foreach (string ShoppingItems in MyShoppingList)
            {
                Console.WriteLine($"Your shopping list:{ShoppingItems}");
            }

            File.WriteAllLines($"{fileLocation}{fileName}", MyShoppingList);

        }
    }
}
