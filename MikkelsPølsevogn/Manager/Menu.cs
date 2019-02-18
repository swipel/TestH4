using System;
using System.Diagnostics;
using MikkelsPølsevogn.Heaters;
using MikkelsPølsevogn.Manager;

namespace MikkelsPølsevogn.Items
{
    public class Menu
    {
        Boiler boiler = new Boiler();
        private bool foodIsProcessing = true;

        //Menu of items
        public Food ChoiceMenu(int numberChoice)
        {
            switch (numberChoice)
            {
                //Boil hotdog
                case 1:
                    Console.WriteLine("Order normal hotdog");
                    NormalHotdog food = (NormalHotdog) Stock.Instance.GetFood(new NormalHotdog());

                    if (food != null)
                    {
                        return food;
                    }
                    else
                    {
                        boiler.StartCooking(new NormalHotdog());
                        while (foodIsProcessing)
                        {
                            food = (NormalHotdog) Stock.Instance.GetFood(new NormalHotdog());
                            if (food != null)
                            {
                                foodIsProcessing = false;
                            }
                        } 
                        
                        Console.WriteLine("Food done");
                        return food;
                    }

                    break;
                //Bread
                case 2:
                    Console.WriteLine("Order bread");

                    break;
                //Burger
                case 3:
                    break;
                default:
                    Console.WriteLine("Not on menu");
                    break;
            }
            return null;
        }
    }
}