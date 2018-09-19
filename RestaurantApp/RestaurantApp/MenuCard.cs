using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    class MenuCard
    {
        ICusine indian;
        ICusine chinese;
        IForeverLove beverages;
        IForeverLove desserts;
      
      
        public List<KeyValuePair<string, int>> list;
        //menu card has the foll : has-a relationship
        public MenuCard()
        {
            this.indian = new IndianCusine();
            this.chinese = new Chinese();
            this.beverages = new Beverages();
            this.desserts = new Desserts();
            this.list = new List<KeyValuePair<string, int>>();
            loadIndian();
            loadChinese();
            loadBeverages();
            loadDesserts();
        }

        void loadIndian()
        {
           
            foreach(KeyValuePair<string, int> pair in  this.indian.maincourses)
            this.list.Add(pair);

            foreach (KeyValuePair<string, int> pair in this.indian.starters)
                this.list.Add(pair);



        }

        void loadChinese()
        {
            foreach (KeyValuePair<string, int> pair in this.chinese.maincourses)
                this.list.Add(pair);

            foreach (KeyValuePair<string, int> pair in this.chinese.starters)
                this.list.Add(pair);

        }

        void loadBeverages()
        {
            foreach (KeyValuePair<string, int> pair in this.beverages.items)
                this.list.Add(pair);
        }

        void loadDesserts()
        {
          foreach (KeyValuePair<string, int> pair in this.desserts.items)
                this.list.Add(pair);
        }

        public void showMenuCard()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\tITEMS\t\t\t\t\t\t\tCOST");
            Console.WriteLine("**********************************************************************************************************************************");
            foreach (KeyValuePair<string, int> pair in this.list)
            {
                
                Console.WriteLine("{0,20}\t\t\t\t\t\t\t{1}",pair.Key,pair.Value);
            }
        }
            

        
    }
}
