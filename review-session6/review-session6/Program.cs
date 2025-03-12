using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review_session6
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                SnackBagManager SBM = new SnackBagManager();
                Customer customer = new Customer();
                customer.Hand = SBM.GetSnackBag();
                Console.WriteLine(customer.Hand);
                customer.Hand.GetRandomSnackUnit().Eat();
                Console.WriteLine(customer.Hand.GetRandomSnackUnit());
            }
        }
    }
}
