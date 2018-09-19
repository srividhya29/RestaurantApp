using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    class Chinese : ICusine
    {
        public IDictionary<string, int> maincourses {get; private set; }
        public IDictionary<string, int> starters { get ;  private set; }
        //static public IDictionary<string, int> maincourseQuantity { get;}
        //static public IDictionary<string, int> startersQuantity { get;}

        public Chinese()
        {
            this.maincourses = new Dictionary<string, int>();
            this.starters = new Dictionary<string, int>();
            addMains();
            addStarters();
        }

          public void addMains()
        {
            maincourses.Add("veg noodles",78);
            //maincourseQuantity.Add("veg noodles", 6);
            maincourses.Add("hakka noodles",89);
            //maincourseQuantity.Add("hakka noodles", 1);




        }

        public void  addStarters()
        {
            starters.Add("fried wantons",78);
            starters.Add("panner momos",89);
            //startersQuantity.Add("fried wantons",2);
            //startersQuantity.Add("panner momos",1);



        }
    }
}
