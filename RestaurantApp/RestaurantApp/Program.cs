using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant("MA MA MIA");


            Customer cust1 = new Customer("Pooja");
            cust1.placeOrder("pulav","roti","plain lassi");
            cust1.viewOrder();
            cust1.cancelOrder("pulav");
            cust1.askForBill("waiter1");

            Customer cust2 = new Customer("Sneha");
            cust2.placeOrder("fried wantons", "panner momos");
            cust2.viewOrder();
            cust2.cancelOrder("pulav");
            cust2.askForBill("waiter1");


           

        }
    }
}
