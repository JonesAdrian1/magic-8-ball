using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Magic8Ball
{
    class Program
    {        
        static void Main(string[] args)
        {
            //Keep current console text color
            ConsoleColor oldColor = Console.ForegroundColor;

            TellPeopleWhatProgramThisIs();

            //Random object
            Random randomObject = new Random();

            while (true)
            {
                string questionString = GetQuestionFromUser();

                //If user typed quit as question, quit app
                if (questionString.ToLower() == "quit")
                {
                    Console.WriteLine("Closing application...");
                    Thread.Sleep(5000);
                    break;
                }

                if(questionString.ToLower() == "fuck you")
                {
                    Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                    Console.WriteLine("Well, fuck you too, negro!!");
                    Thread.Sleep(3000);
                    Console.WriteLine("Bye felicia!");
                    Thread.Sleep(500);
                    break;
                }

                if (questionString.Length == 0)
                {
                    Console.WriteLine("You need to ask a question!");
                    continue;
                }
                else
                {
                    int numberOfSecondsToSleep = randomObject.Next(5) + 1;
                    Console.WriteLine("Thinking about your answer, please wait...");
                    Thread.Sleep(numberOfSecondsToSleep * 1000);
                }

                

                //Get random number
                int randomNumber = randomObject.Next(4);

                Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);

                //Response from 8 ball
                switch(randomNumber)
                {
                    case 0:
                        {
                            Console.WriteLine("Yes!!");
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("NO!!!");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Maybe!!");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Ask later!");
                            break;
                        }
                }
            }//end of while loop

            //Cleaning up
            Console.ForegroundColor = oldColor;
        }

        static void TellPeopleWhatProgramThisIs()
        {
            //Change color of console
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Magic 8 Ball");
        }

        static string GetQuestionFromUser()
        {
            //THis will ask user for question and store question in questionString variable
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Ask a question: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            string questionString = Console.ReadLine();

            return questionString;
        }
    }
}
