using System;
using System.Collections.Generic;
using System.Threading;
using MikkelsPølsevogn.Items;
using MikkelsPølsevogn.Manager;

namespace MikkelsPølsevogn.Heaters
{
    public class Boiler : ICookingDevice
    {        
        private Timer tm = null;
        private AutoResetEvent autoEvent = null;

        private int currentCookingTime = 0;
        private int cookingTime;
        private Food food;
        private int amount = 1;        
        
        //Start cooking of food
       public void StartCooking(Food food)
       {
           if (food is NormalHotdog)
           {
               //test time
               this.cookingTime = 5;
               //Real time
               //this.cookingTime = 10 * 60;
               
               amount = 60;
               food.HotTime = 60 * 60;

           } else if (food is Bread)
           {
               this.cookingTime = 1 * 60;
               amount = 10;
           }
           //Start timer of cooking
           StartTimer();
       }
       
       //Method to start timer
       public void StartTimer()
       {
           autoEvent = new AutoResetEvent(false);
           tm = new Timer(cookingDone, autoEvent, 1000, 1000);
       }
       
       //Executed when timer is done
       private void cookingDone(Object stateInfo)
       {
           if (currentCookingTime < cookingTime)
           {
               currentCookingTime++;
               return;
           }

           for (int i = 0; i < this.amount; i++)
           {
               Stock.Instance.AddFood(food);
           }           
           
           tm.Dispose();
       }
    }
}