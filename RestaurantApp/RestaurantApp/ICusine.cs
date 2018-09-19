using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    interface ICusine
    {
        IDictionary<string, int> maincourses { get; }
        //IDictionary<string, int> maincourseQuantity { get; }

        IDictionary<string, int> starters { get; }
        //IDictionary<string, int> startersQuantity { get; }

        void addMains();
        void addStarters();

    }
}
