using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    class Desserts : IForeverLove
    {
        public IDictionary<string, int> items { get ; private set; }

        public Desserts()
        {
            this.items = new Dictionary<string, int>();
            additems();
        }

        public void additems()
        {
            items.Add("butterstoch mouse",90);
            items.Add("choco truffle",80);
            
        }


    }
}
