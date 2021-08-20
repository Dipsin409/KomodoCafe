using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_KomodoCafe_Console
{
    public class ProgramUI
    {
        public void Run()
        {
            Console.Title = "Menu";
            Console.WriteLine("[1] Full Meal ");
            Console.WriteLine("[2] Partial Meal");
            Console.WriteLine("[3] Buffet");
            Console.WriteLine("[4] Settings");

            var input = Console.ReadLine();

            if (input == "1")
            {
                // full meal [1]
                Fullmeal();

            }

            if (input == "2")
            {
                // partial meal [2]
                Partialmeal();
            }

            if (input == "3")
            {
                // buffet [3]
                Buffet();
            }

            if (input == "4")
            {
                // settings [4]
                Settings();
            }

        }
        public static void Fullmeal()
        {
            Console.Clear();
            Console.WriteLine("Full meal #1 comes with all the meat and all the trimmings!");
            Console.ReadLine();
        }

        public static void Partialmeal()
        {
            Console.Clear();
            Console.WriteLine("Partial meal #2 comes with a main meal with no sides");
            Console.ReadLine();
        }

        public static void Buffet()
        {
            Console.Clear();
            Console.WriteLine("The buffet #3 comes with all you can eat for 1 hour");
            Console.ReadLine();
        }

        public static void Settings()
        {
            Console.Clear();
            Console.WriteLine("Settings");
            Console.WriteLine("Press [1] to add a item to menu");
            Console.ReadLine();

        }
    }
}
        
    

