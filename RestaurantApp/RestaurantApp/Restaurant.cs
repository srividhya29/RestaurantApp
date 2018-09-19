using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    class Restaurant
    {
        public string name {get;private set;}
        private MenuCard  menu; 
        public Restaurant(string name)
        {
            this.name = name;
            welcome();
           menu = new MenuCard();
            menu.showMenuCard();
            

        }

        private void  welcome()
        {
            Console.WriteLine("***********************************Welcome to {0} restaurant********************", this.name);
            Console.WriteLine("*******************************Heres the menu********************************8 ");
        }
    }
}
