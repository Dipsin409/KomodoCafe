using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_KomodoCafe
{
    public class Menu
    {
        public string MealName { get; set; }
        public int ProductNumber { get; set; }
        public string ProductDescription { get; set; }
        public List<string> Ingredients { get; set; }
        public double Price { get; set; }
        public Menu(int productNumber, string productDescription, double price, List<string> ingredients, string mealName)
        {

            ProductNumber = productNumber;
            ProductDescription = productDescription;
            Price = price;
            Ingredients = ingredients;
            MealName = mealName;




        }

        public Menu()
        {
        }



        //properties
        // menu number and name
        //constructor on how menu item needs to be constructed
        // poco


    }
}
