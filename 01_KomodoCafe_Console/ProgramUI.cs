﻿using _01_KomodoCafe;
using _01_KomodoCafe_Repository;
using System;
using System.Collections.Generic;
using System.Threading;

namespace _01_KomodoCafe_Console
{

    public class ProgramUI
    {


        private readonly MenuRepo _repo = new MenuRepo();

        public int productNumber { get; private set; }

        //public string mealName { get; private set; }

        public void Run()
        {
            Menu();
        }

        public void SeedContent()
        {
            //Menu m1 = new Menu();
            //Menu m2 = new Menu();
            //Menu m3 = new Menu();
            //Menu m4 = new Menu();
            //Changed to Below
            Menu m1 = new Menu(1, "Cheese Burger Meal", 7.99, new List<string> { "bun", "cheese", "pickle", "lettuce" }, "Burger Combo");
            _repo.AddContentToDirectory(m1);
            Menu m2 = new Menu();
            Menu m3 = new Menu();
            Menu m4 = new Menu();

            Console.WriteLine("Seeding....");
        }

        public void Menu()
        {
            bool continueToRun = true;

            while (continueToRun)
            {
                Console.Clear();

                Console.WriteLine("Menu:\n" +
                    "1. Show current menu\n" +
                    "2. Search by text\n" +
                    "3. Add new menu item\n" +
                    "4. Remove item\n" +
                    "5. Exit");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        DisplayAllContents();
                        break;

                    case "2":
                        GetContentByTitle();
                        break;

                    case "3":
                        AddNewContent();
                        break;

                    case "4":
                        RemoveContent();
                        break;

                    case "exit":

                    case "EXIT":

                    case "5":

                        continueToRun = false;

                        break;

                    default:

                        Console.WriteLine("Please enter a valid selection\n" +
                            "Press any key to continue...");

                        Console.ReadKey();

                        break;

                }
            }
            Console.Clear();

            Console.WriteLine("Thanks for shopping!");

            Thread.Sleep(2000);
        }



        public void DisplayAllContents()
        {
            Console.Clear();
            

            
           

            
        }

        public void GetContentByTitle()
        {
            throw new NotImplementedException();
        }

        public void AddNewContent()
        {
            Console.Clear();

            Menu content = new Menu();

            bool isValidTitle = false;
            while (!isValidTitle)
            {
                Console.WriteLine("Please insert Title:");
                string title = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(title))
                {
                    Console.WriteLine("Please enter a valid title (press any key to continue");

                }

                else
                {
                    content.MealName = title;
                    isValidTitle = true;
                }
            }

            // enter description
            Console.WriteLine("Please list a brief Description: ");
            string description = Console.ReadLine();
            content.ProductDescription = string.IsNullOrWhiteSpace(description) ? "(No Description)" : description;


            // enter number of the item
            Console.Write("Please enter the product Number: ");
            double stars = double.Parse(Console.ReadLine());
            if (stars > 30)
            {
                content.ProductNumber = 30;
            }
            else if (stars < 0)
            {
                content.ProductNumber = 0;
            }
            else
            {
                content.ProductNumber = productNumber;
            }


        }



        public void RemoveContent()
        {
            Console.Clear();
            Console.Write("Enter the product to remove: ");

            string title = Console.ReadLine();

            MenuRepo content = _repo.GetContentByTitle(title);

            if (content == null)
            {
                Console.WriteLine("Content not found :(");
            }
            else
            {
                DisplayContents(content);
                Console.WriteLine("Do you want to delete this forever? (y/n");

                string answer = Console.ReadLine();
                if (answer.ToLower() == "y" || answer.ToLower() == "yes")
                {
                    _repo.DeleteExistingContent(content);
                    Console.WriteLine("Product has been perm deleted...");
                }
                else
                {
                    Console.WriteLine("Disregard...");
                }
            }
            ContinueMessage();
  
        }

        private void ContinueMessage()
        {
            throw new NotImplementedException();
        }

        private void DisplayContents(MenuRepo content)
        {
            throw new NotImplementedException();
        }
    }


}




