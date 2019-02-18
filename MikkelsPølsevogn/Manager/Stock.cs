using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MikkelsPølsevogn.Items;

namespace MikkelsPølsevogn.Manager
{
    public sealed class Stock
    {
        private static Stock instance;
        //Lock object
        private static readonly object oLock = new object();
        
        //Singleton
        public static Stock Instance
        {
            get
            {
                lock (oLock)
                {
                    if (instance == null)
                    {
                        instance = new Stock();
                    }

                    return instance;
                }
            }
        }

        //List with all food there is ready
        private List<Food> foodList = new List<Food>();

        //Return the type of food there is requested
        public Food GetFood(Food food)
        {
            foreach (Food row in this.foodList)
            {
                if (food.GetType() == row.GetType())
                {
                    foodList.Remove(row);
                    return row;
                }
            }

            return null;
        }

        //Add food to stock there is ready to be given to customers
        public void AddFood(Food foodItem)
        {
            this.foodList.Add(foodItem);
        }
    }
}