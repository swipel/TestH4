using System;
using MikkelsPølsevogn.Heaters;
using MikkelsPølsevogn.Items;

namespace MikkelsPølsevogn.Users
{
    public class Consumer : Human
    {
        public Consumer(string name) : base(name)
        {
        }
        
        //Simulate a order choice
        public void Order()
        {
            Random rnd = new Random();
            int itemChoice = rnd.Next(1, 2);
            Food temp = new Menu().ChoiceMenu(itemChoice);
            if (temp != null)
            {
                Console.WriteLine("Eats food" + temp.GetType());
            }
        }

    }
}