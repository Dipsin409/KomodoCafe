using _01_KomodoCafe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01_KomodoCafe_Console
{

    public class Menu
    {
        public class ProgramUI
        {
            private readonly Menu _repo = new Menu();
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
                Menu m1 = new Menu();
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

                    Console.WriteLine("Menue:\n" +
                        "1. Show current menu\n" +
                        "2. Search by text\n" +
                        "3. Add new item\n" +
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
                throw new NotImplementedException();

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
                    Console.WriteLine("Title:");
                    string title = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(title))
                    {
                        Console.WriteLine("Please enter a valid title (press any key to continue");

                    }

                    else
                    {
                        content.
                        isValidTitle = true;
                    }
                }
            }

            public void RemoveContent()
            {
                throw new NotImplementedException();
            }


        }


    }
}



