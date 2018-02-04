using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet1
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice;

            //int tickerCount = 0;
            //Dragon INSERT = new Dragon(true, true, true, "red");
            Dragon myDragon = new Dragon("red", 50, 50, 50);
            Console.WriteLine("You are so lucky to have found a dragon!");
            Console.WriteLine("\nWhat are you going to call your dragon?");
            myDragon.DragonName = Console.ReadLine();
            Console.WriteLine("You should decide what color " + myDragon.DragonName + " is");
            myDragon.Color = Console.ReadLine().ToLower();

            do
            {
                Console.WriteLine("\nWhat are you going to do with " + myDragon.DragonName + "?");
                Console.WriteLine("\nTo take a ride with " + myDragon.DragonName + ", enter 1");
                Console.WriteLine("To feed " + myDragon.DragonName + ", enter 2");
                Console.WriteLine("To go conquer other kingdoms, enter 3");
                Console.WriteLine("To see how " + myDragon.DragonName + " is doing, enter 4");
                Console.WriteLine("Time for " + myDragon.DragonName + " to take a nap!, type 5");
                Console.WriteLine("\nTo say goodbye to " + myDragon.DragonName + " and go home,type 6");
                if (myDragon.TickerCount == 10)
                { Console.WriteLine("\nMake sure " + myDragon.DragonName + " is rested and fed!"); }
                if (myDragon.TickerCount == 30)
                { Console.WriteLine("\n"+ myDragon.DragonName + " has had a long day!"); }
                 
                myDragon.tick();
                //Console.WriteLine("here is your count" +myDragon.TickerCount);
                userChoice = int.Parse(Console.ReadLine());

                //Console.WriteLine(myDragon.TickerCount);


                switch (userChoice)
                {
                    case 1:
                        Console.Clear();
                        myDragon.Transport();
                        break;
                    case 2:
                        Console.Clear();
                        int hunger = myDragon.Eat();
                        //string stomachStatus = myDragon.Feed();
                        //Console.WriteLine(stomachStatus);
                        break;
                    case 3:
                        Console.Clear();
                        myDragon.Conquer();
                        break;
                    case 4:
                        Console.Clear();

                        Console.WriteLine("Hunger rating: " + myDragon.Hunger);
                        Console.WriteLine("Fire rating: " + myDragon.FireRating);
                        Console.WriteLine("Flight rating: " + myDragon.FlightRating);
                        Console.WriteLine(myDragon.DragonName + " is " +myDragon.Color);
                        //Console.WriteLine(myDragon.DragonName + " can fly: " + myDragon.CanFly);
                        //Console.WriteLine(myDragon.DragonName + " is hungry: " + myDragon.Hunger);
                        //Console.WriteLine(myDragon.DragonName + " can breathe fire: " + myDragon.CanBreatheFire);
                        //Console.WriteLine(myDragon.DragonName + " is " + myDragon.Color);
                        break;
                    case 5:
                        Console.Clear();
                        myDragon.Sleep();
                        Console.WriteLine(myDragon.DragonName + " must be tired after a long day");
                        break;

                }


            } while (userChoice != 6);
        }
    }
}
