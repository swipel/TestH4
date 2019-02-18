using System.Threading;
using MikkelsPølsevogn.Items;
using MikkelsPølsevogn.Users;

namespace MikkelsPølsevogn
{
    public class Simulator
    {
        public void Start()
        {
            string name = "Kunde:";
            int customerNumber = 0;
            int maxCustomer = 4;
            int curretAmountOfCustomer = 0;
            

               while (true)
               {
                   //Limit customer to 4 at a time
                   if (curretAmountOfCustomer < maxCustomer)
                   {
                       curretAmountOfCustomer++;
                       //Create customer
                      new Consumer(name + customerNumber).Order();
                       curretAmountOfCustomer--;
                   }

                   Thread.Sleep(250);
               }
               
        }
    }
}