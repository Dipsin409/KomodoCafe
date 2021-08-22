using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
      class MenuRepo
    {
        protected readonly List<Menu> _menuDirectory = new List<Menu>();

        public bool ProductName { get; private set; }


        //crud create read update delete



        //create
        public bool AddContentToDirectory(Menu items)
        {
            int startingCount = _menuDirectory.Count;

            _menuDirectory.Add(items);

            bool wasAdded = _menuDirectory.Count > startingCount;
            return wasAdded;

            // return _contentDirectory.Count > startingCount;
        }

        //read

        public List<Menu> GetItems()
        {
            return _menuDirectory;
        }

        //public bool GetContentByTitle(string productName)
        //{


        //     List<Menu> productNames = new List<Menu>();
        //    foreach(Menu item in _menuDirectory)
        //    {
        //        if (item.productName)
        //        {
        //            this.productName = productName;
        //            return productNames;
        //        }
        //    }
        //         return null;
        //}


         Menu GetMenuByName(string mealName)
        {
            foreach(Menu item in _menuDirectory)
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
            Menu oldContent = GetMenuByMealName(originalTitle);

            if (oldContent != null)
            {
                oldContent.Title = newContent.Title;


            }
        }


        //delete
    }

    public class MenuContentRepository
    {
    }
}
