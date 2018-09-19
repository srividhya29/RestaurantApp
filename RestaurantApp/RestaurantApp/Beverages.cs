using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    class Beverages : IForeverLove
    {
        public IDictionary<string, int> items { get ; private set; }

        public Beverages()
        {
            items = new Dictionary<string, int>();
            additems();
        }

        public void additems()
        {

            items.Add("cold coffe",67);
            items.Add("ice tea",90);
            items.Add("plain lassi",70);
        
        }
    }
}
