using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _01_KomodoCafe_Repository
{
      public class MenuRepo
      { 
        protected readonly List<Menu> _menuDirectory = new List<Menu>();

        public bool ProductName { get; private set; } 
        //crud create read update delete
        //create
        public bool AddContentToDirectory(MenuRepo items)
        {
            int startingCount = _menuDirectory.Count;

            _menuDirectory.Add(items);

            bool wasAdded = _menuDirectory.Count > startingCount;
            return wasAdded;

            // return _contentDirectory.Count > startingCount;
        }

        //read

        public List<MenuRepo> GetItems()
        {
            return _menuDirectory;
        }




        MenuRepo GetMealByName(string mealName)
        {
            foreach (MenuRepo item in _01_menuDirectory)
            {
                if (item.MealName == mealName)
                {
                    return item;
                }
            }
            return null;
        }
        //update

        public bool UpdateExistingContent(string originalTitle, Menu newContent)
        {
            Menu oldContent = GetMealByName(originalTitle);

            if (oldContent != null)
            {
                oldContent.MealName = newContent.MealName;
                oldContent.ProductNumber = newContent.ProductNumber;
                oldContent.ProductDescription = newContent.ProductDescription;
                oldContent.Ingredients = newContent.Ingredients;
                oldContent.Price = newContent.Price;


                return true;

            }

            return false;
        }


        //delete

        public bool DeleteExistingContent(MenuRepo existingContent)
        {
            bool deleteResult = _menuDirectory.Remove(existingContent);
            return deleteResult;

        }
        public class MenuContentRepository
        {
        }
      }

}
