using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    class Customer 
    {
        public string name { get; private set; }

       // public override int id => throw new NotImplementedException();
        private static int customerId = 0;
        public static int tableNumber = 0;
        private MenuCard menu;
        public List<KeyValuePair<string, int>> orders { get; private set;}
        public Customer(string name)
        {
            this.name = name;
            Customer.customerId = Customer.customerId + 1;
            Customer.tableNumber = Customer.tableNumber + 1;
            this.menu = new MenuCard();
            this.orders = new List<KeyValuePair<string, int>>();
        }

        public void placeOrder(params string[] itemNames)
        {
            Boolean itemFound = false;
            if(itemNames.Length > 0 )
            {
              foreach(string i in itemNames)
                {

                    foreach(KeyValuePair<string, int> pair in this.menu.list)
                    {
                        if(i == pair.Key)
                        {
                            this.orders.Add(pair);
                            itemFound = true;
                            break;

                        }
                        
                    }
                }
            }
            if(itemFound == false)
            {
                Console.WriteLine("item not found");
            }

            

        }

        public void cancelOrder(params string[] itemNames)
        {
            Boolean itemDeleted = false;
            if (itemNames.Length > 0 && this.orders.Count > 0)
            {
                foreach (string i in itemNames)
                {
                    foreach (KeyValuePair<string, int> pair in this.menu.list)
                    {
                        if (i == pair.Key)
                        {
                            this.orders.Remove(pair);
                            itemDeleted = true;
                            break;

                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("You have not ordered the items to cancel it");
            }

        }

       

        public void viewOrder()
        {
            if(this.orders.Count > 0)
            {
                Console.WriteLine("Your Orders name:{0} table Number{1}",this.name,Customer.tableNumber);
                Console.WriteLine("**********************************************");
                foreach (KeyValuePair<string, int> pair in this.orders)
                {
                    Console.WriteLine("\t\t{0}", pair.Key);
                }
            }
            else
            {
                Console.WriteLine("there is no order to view");
            }
           
        }

         public void askForBill(string name)
         {
            RestaurantEmployeer re = new RestaurantEmployeer(name);
            re.generateBill(this);
         }
    }
}
