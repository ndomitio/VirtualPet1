using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet1
{
    public class Dragon
    {
        //originally had mostly bool fields, decided to add int "ratings" later to make the program more interesting.  


        //fields 

        //private bool isHungry;
        private int hunger;
        //private bool canFly;
        private int flightRating;
        private string color;
        //private bool canBreatheFire;
        private int fireRating;
        private int tickerCount;
        private string dragonName;
        //properties 


        public int TickerCount
        {
            get { return this.tickerCount; }
            set { this.tickerCount = value; }
        }

        public int FireRating
        {
            get { return this.fireRating; }
            set { this.fireRating = value; }

        }

        public int FlightRating
        {
            get { return this.flightRating; }
            set { this.flightRating = value; }
        }

        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }

        public string DragonName
        {
            get { return this.dragonName; }
            set { this.dragonName = value; }
        }
        //public bool IsHungry
        //{
        //    get { return this.isHungry; }
        //    set { this.isHungry = value; }
        //}

        //public bool CanFly
        //{
        //    get { return this.canFly; }
        //   set { this.canFly = value; }
        //}


        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        //public bool CanBreatheFire
        //{
        //    get { return this.canBreatheFire; }
        //    set { this.canBreatheFire = value; }
        //}

        //constructors 

        public Dragon()
        {

        }

        public Dragon(string color, int flightRating, int fireRating, int hunger)
        {
            this.color = color;
            this.flightRating = flightRating;
            this.fireRating = fireRating;
            this.hunger = hunger;
        }

        public Dragon(int fireRating, int hunger, string color)
        {
            this.fireRating = fireRating;
            this.hunger = hunger;
            this.color = color;

        }
        //public Dragon(string color, bool isHungry, bool canFly)
        //{
        //    this.color = color;
        //    this.isHungry = isHungry;
        //    this.canFly = canFly;
        //}

        //public Dragon(bool canBreatheFire, bool canFly, bool isHungry, string color)
        //{
         //   this.canBreatheFire = canBreatheFire;
          //  this.canFly = canFly;
          //  this.isHungry = isHungry;
       // }

        //methods

        public int Conquer()
        {
            if ((flightRating > 35) && (fireRating > 35))
            {
                Console.WriteLine("Get ready for battle, it is time to conquer other kingdoms!");
                return (flightRating -= 20) & (fireRating -= 20) & (hunger += 20);

            }
            else
            {
                Console.WriteLine(dragonName + " is not up for battle right now.");
                return hunger += 0;
            }
            //if ((canFly == true) && (CanBreatheFire == true) && (tickerCount < 20))
            //{
            //    Console.Clear();
            //    Console.WriteLine("Good luck on your conquest!");

            //}

            //else
            //{
            //    Console.Clear();
            //    Console.WriteLine("Sorry, you will not be able to conquer any new lands today");
            //}

        }

        public void Sleep()
        {
            hunger = 30;
            fireRating = 50;
            flightRating = 50;
        }

        public int Eat()
        {
            if (hunger > 20)
            {
                Console.WriteLine(DragonName + " is hungry, time to eat!");
                return (hunger = 0) & (flightRating = 50) & (fireRating = 50);

            }
            else
            { Console.WriteLine(DragonName + " isn't hungry right now, definitely later!"); }
            return hunger += 0;
        }


        //public string Feed()
        //{
        //    if ((isHungry == true) && (canFly == true))
        //    {
        //        Console.Clear();

        //        isHungry = false;
        //        return "You don't have to feed " + DragonName + ", he will fly and grab his own food.";
        //    }

        //    else if (tickerCount > 5)
        //    {
        //        Console.Clear();

        //        isHungry = false;
        //        return DragonName + "has had a long day, good to feed your dragon before they eat you!";

        //    }

        //    else if (isHungry == true)
        //    {
        //        Console.Clear();

        //        isHungry = false;
        //        return "Time to go feed " + DragonName + ", be careful not to be eaten yourself.";

        //    }

        //    else
        //    {
        //        Console.Clear();

        //        isHungry = false;
        //        return "I guess your dragon isn't that hungry ¯\\_(ツ)_/¯ ";
        //    }


        //}

        public void tick()
        {
            tickerCount++; hunger += 3; fireRating -= 3; flightRating -= 3;
        }

        public static void clear()
        {

        }

        public int Transport()
        {
            if ((flightRating > 20) && (hunger < 30))
            {
                Console.WriteLine("Hold on tight, time to fly!");
                return ((flightRating -= 20) & (hunger += 10));
            }
            else if (hunger > 30)
            {
                Console.WriteLine("You should feed " + dragonName + " first, no one wants to get near a hungry dragon!");
                return flightRating += 0;
            }
            else
            {
                Console.WriteLine("Your dragon does not want to fly right now");
                return flightRating += 0;
            }
            //if ((canFly == true) && (isHungry == false) && (tickerCount < 50))
            //{
            //    Console.Clear();

            //    Console.WriteLine("Looks like your dragon is ready to fly, hold on tight!");
            //    return isHungry = true;


            //}
            //else if (isHungry == true)
            //{
            //    Console.Clear();

            //    Console.WriteLine("You should probably feed your dragon first, I would not want to fly on a hungry dragon.");
            //    return canFly = true;
            //}
            //else
            //{
            //    Console.Clear();

            //    Console.WriteLine("Let's do something else!");
            //    return isHungry = true;
        }
    }

}



