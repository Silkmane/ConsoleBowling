using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleBowling
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Random r = new Random();
            Random p = new Random();
            int turn = 10;
             
            int pinCount = r.Next(0, 10);//All Pins

            int pickUp = 10 - pinCount;//Spar pins 
            int prePickUpScore = pinCount;//spar pins

            int pickUpScore = 0;//overall spar score
            int FinalScore = 0;//overall spar and strike score

            for (int i = 0; i <= turn; i++)
            {
                Console.WriteLine("Frame " + i);
                Console.WriteLine("First roll was " + pinCount);  

                if(i == 10) //last frame
                {
                    if(pinCount == 10) //perfect strike
                    {
                        FinalScore += 10;//add perfect strike to score
                        for(int final = 0; final <=1; final++)//two additional frames added
                        {
                            if (pinCount != 10)
                            {
                                int pickUpSpar = p.Next(0, pickUp);
                                pickUpScore = prePickUpScore + pickUpSpar;

                                Console.WriteLine("Pickup was " + pickUpSpar);
                                Console.WriteLine("current score = " + pickUpScore);
                                FinalScore += pickUpScore;
                            }
                            else
                            {
                                FinalScore += 10;
                            }
                        }
                        
                    }
                    else //last frame, but no strike was thrown
                    {
                        if (pinCount != 10)
                        {
                            int pickUpSpar = p.Next(0, pickUp);
                            pickUpScore = prePickUpScore + pickUpSpar;

                            Console.WriteLine("Pickup was " + pickUpSpar);
                            Console.WriteLine("current score = " + pickUpScore);
                            FinalScore += pickUpScore;
                        }
                        else
                        {
                            FinalScore += 10;
                        }
                    }
                }
                else 
                {
                    if (pinCount != 10) //not the last frame 
                    {
                        int pickUpSpar = p.Next(0, pickUp);
                        pickUpScore = prePickUpScore + pickUpSpar;

                        Console.WriteLine("Pickup was " + pickUpSpar);
                        Console.WriteLine("current score = " + pickUpScore);
                        FinalScore += pickUpScore;
                    }
                    else
                    {
                        FinalScore += 10;
                    }
                }

                
                
                Console.WriteLine("Final Score: " + FinalScore);
                Console.ReadLine();
            }
        }
    }
}
