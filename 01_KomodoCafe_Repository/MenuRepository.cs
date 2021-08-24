using _01_KomodoCafe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _01_KomodoCafe_Repository
{
    // Plain Old C# Object POCO


    public class MenuRepo
    {
        public List<Menu> _listOfMenuItems = new List<Menu>();
        public class MenuContentRepository { }


        //Create
        public bool AddContentToDirectory(Menu items)
        {
            int startingCount = _listOfMenuItems.Count;

            _listOfMenuItems.Add(items);

            bool wasAdded = _listOfMenuItems.Count > startingCount;
            return wasAdded;
        }

        //Read
        public List<Menu> GetContentList()
        {
            return _listOfMenuItems;
        }

        //Update
        public bool UpdateExistingContent(string originalTitle, Menu newContent)
        {

            Menu oldContent = GetMealByName(originalTitle);
            if(oldContent != null)
            {
                oldContent.MealName = newContent.MealName;
                oldContent.ProductNumber = newContent.ProductNumber;
                oldContent.ProductDescription = newContent.ProductDescription;
                oldContent.Price = newContent.Price;

                return true;
            }
            else
            {
                return false;
            }


        }


        //Delete
        public bool DeleteExistingContent(string title)
        {
            Menu content = GetMealByName(title);

            if (content == null)
            {
                return false;
            }

            int initialCount = _listOfMenuItems.Count;
            _listOfMenuItems.Remove(content);

            if (initialCount > _listOfMenuItems.Count)
            {
                return true;

            }
            else
            {
                return false;
            }

        }

        public Menu GetMealByName(string mealName)
        {
            //List<Menu>mealNames = new List<Menu>();
            foreach (Menu items in _listOfMenuItems)
            {
                if (items.MealName == mealName)
                {
                    return items;
                }
            }
            return null;
        }

        public Menu GetContentByTitle(string title)
        {
            foreach (Menu content in _listOfMenuItems)
            {
                if (content.MealName == title)
                {
                    return content;
                }
            }
            return null;
        }






    }

}



