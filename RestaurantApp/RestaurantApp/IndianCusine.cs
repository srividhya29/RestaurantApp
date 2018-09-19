using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    class IndianCusine: ICusine
    {
        public IDictionary<string, int> maincourses { get; private set; }

        public IDictionary<string, int> starters { get;private set; }

       // public IDictionary<string, int> maincourseQuantity { get; private set; }
       // public IDictionary<string, int> startersQuantity { get; private set; }



        public IndianCusine()
        {
            this.maincourses = new Dictionary<string, int>();
            this.starters = new Dictionary<string, int>();
            addMains();
            addStarters();
        }

        public void addMains()
        {
           
            maincourses.Add("roti",44);
            maincourses.Add("pulav",78);
            maincourses.Add("dum briyani",12);
            //maincourseQuantity.Add("roti", 1);
            //maincourseQuantity.Add("pulav", 0);
            //maincourseQuantity.Add("dum briyani", 1);

        }

        public void addStarters()
        {
            starters.Add("honey potato",123);
            starters.Add("mushroom",78);
            //startersQuantity.Add("honey potato", 3);
            //startersQuantity.Add("mushroon", 1);


        }

    }
}
