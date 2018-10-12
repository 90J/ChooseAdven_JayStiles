using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseAdventure_JayStiles
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //vars
            string check = "y";
            string direction;


            //greet the user
            Console.WriteLine("Welcome weary traveler!");
            Console.WriteLine("It appears you are lost in this great forest.");
            Console.WriteLine("Well, you have some choices ahead of you.");
            Console.WriteLine("I cannot tell you what trials await, but I can give some directions.");
            Console.WriteLine("To the north is a mountain. Would you like to go there?");
            Console.WriteLine("To the east is the Great Sea. How about a day at the beach?");
            Console.WriteLine("To the south is the Swamp. You cannot head that direction.");
            Console.WriteLine("And to the west, well, I just came from there and since you have no weapons, the bandits will kill you.");
           


            //ask initial choice and send to methods
            while (true)
            {
                Console.Write("What direction would you like to head? (n or e')");
                direction = Console.ReadLine();

                if (direction == "n")
                {
                    IWentNorth();
                }
                else if (direction == "e")
                {
                    IWentEast();
                }

                else
                {
                    return;
                }

                // check for continue

                Console.Write("Would you like to try another journey? (y/n): ");
                check = Console.ReadLine();
                if (check != "y")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("It's your funeral...");
                }
                //method 1
                void IWentNorth()
                {
                    string decision;


                    Console.WriteLine("You button up your coat and head up the mountain. Damn is is cold.");
                    Console.WriteLine("Hours pass.");
                    Console.WriteLine("You decide to set up camp as it starts to snow.");
                    Console.Write("Do you set up your tent under the overhang? (y/n): ");
                    decision = Console.ReadLine();

                    if (decision == "y")
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("You have died. The snow overnight packed you into the overhang and you could not escape.");

                    }
                    else
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Over the course of the night, the trail you were on became icy and you slid all the way back to where you started...");
                        Console.WriteLine("But, hey, at least you are alive, right?");
                        Console.WriteLine("I guess you could head east.");
                        Console.WriteLine("Head east now? (y/n): ");
                        decision = Console.ReadLine();


                    }



                }

                //method 2
                void IWentEast()
                {
                    string decision;


                    Console.WriteLine("After several days of walkng you can smell the salt air.");
                    Console.WriteLine("Then you hear the waves crashing.");
                    Console.Write("Go for a swim? (y/n): ");
                    decision = Console.ReadLine();

                    if (decision == "y")
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("You have died. You were eaten by a shark.");

                    }
                    else
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("You have died. You were killed by a sharknado");
                        Console.WriteLine("Sorry about your luck, I ran out of time.");

                    }



                }
            }
        }


    }


}

        