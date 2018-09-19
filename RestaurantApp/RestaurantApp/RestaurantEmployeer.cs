using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    class RestaurantEmployeer
    {
        public string name { get; private set; }
        //private static 

        public RestaurantEmployeer(string name)
        {
            this.name = name;
        }

        public void generateBill(Object o)
        {
            Customer currentCustomer = (o as Customer);
            int total = 0;
            Console.WriteLine();
            Console.WriteLine("Bill for {0} : for table {1}", currentCustomer.name,Customer.tableNumber);
            Console.WriteLine("**************************************************************************");
            foreach(KeyValuePair<string, int> pair in currentCustomer.orders){
                Console.WriteLine("{0,20}\t\t{1:C}", pair.Key,pair.Value);
                total = total + pair.Value;
                 
            }
            Console.WriteLine();
            Console.WriteLine("Grand Total : {0}", total);

        }

        public void setQuantity(string itemName, int quantity,params ICusine[] cusine)
        {
          /*  Object o = cusine.GetType();
          if (o is IndianCusine)
            {
                (o as IndianCusine).maincourseQuantity.Add(itemName, quantity);
               
            }
          if(o is Chinese)
            {
                (o as IndianCusine).maincourseQuantity.Add(itemName, quantity);
            }*/
        }

        public void setQuantity(string itemName, int quantity, params IForeverLove[] cusine)
        {


        }

    }
}
