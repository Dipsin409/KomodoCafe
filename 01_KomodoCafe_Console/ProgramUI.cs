using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01_KomodoCafe_Console
{
    public class ProgramUI
    {
        public void Run()
        {
            SeedContent();

            Menu();
        }
        public void SeedContent()
        {
            Console.WriteLine("Seeding....");

            Menu m1 = new Menu();
            Menu m2 = new Menu();
            Menu m3 = new Menu();
            Menu m4 = new Menu();

            


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


        private void DisplayAllContents()
        {
         

        }
           
        private void GetContentByTitle()
        {
            throw new NotImplementedException();
        }

        private void AddNewContent()
        {
            throw new NotImplementedException();
        }

        private void RemoveContent()
        {
            throw new NotImplementedException();
        }

        
    }
}



