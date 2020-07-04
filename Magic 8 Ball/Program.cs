using System;
using System.Collections.Generic;
using System.Threading;

namespace Magic_8_Ball
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                          88888888888                             ");
            Console.WriteLine("                       88             88                          ");
            Console.WriteLine("                     88                 88                        ");
            Console.WriteLine("                    88       MAGIC       88                       ");
            Console.WriteLine("                   88                     88                      ");
            Console.WriteLine("                  88         ( 8 )         88                     ");
            Console.WriteLine("                   88                     88                      ");
            Console.WriteLine("                    88       BALL?       88                       ");
            Console.WriteLine("                     88                 88                        ");
            Console.WriteLine("                       88             88                          ");
            Console.WriteLine("                          88888888888                             ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("===                                                            ===");
            Console.WriteLine("===                    Ask the MAGIC 8 Ball                    ===");           
            Console.WriteLine("===                                                            ===");
            Console.WriteLine("===                  Concentrate on the Question               ===");
            Console.WriteLine("===              press the ENTER key for the answer            ===");
            Console.WriteLine("===                                                            ===");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();

          // Console.ReadLine();

            var ballArray = new string[10];
                       
            ballArray[0] = "            As I see it, yes."; 
            ballArray[1] = "            It is certain.";
            ballArray[2] = "            It is decidedly so.";
            ballArray[3] = "            Signs point to yes.";
            ballArray[4] = "            Don’t count on it.";
            ballArray[5] = "            Outlook not so good.";
            ballArray[6] = "            Very doubtful.";
            ballArray[7] = "            Reply hazy, try again.";
            ballArray[8] = "            Concentrate and ask again.";
            ballArray[9] = "            Ask again later";

            Start:

            var rng = new Random();

            for (int i = 0; i < 1; i++)
            {
                var userInput = Console.ReadLine();

                if (userInput == "")
                {
                    Console.WriteLine("You need to enter a question!");
                    goto Start;
                }
                else
                {
                    var randomize = rng.Next(0, ballArray.Length - 1);
                    Console.WriteLine();
                    Console.WriteLine("------------------------------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine($"         { ballArray[randomize] }                    ");
                    Console.WriteLine();
                    Console.WriteLine("------------------------------------------------------------------");
                    Console.WriteLine("-              HIT ENTER TO ASK ANOTHER QUESTION                 -");
                    Console.WriteLine("------------------------------------------------------------------");
                    Console.WriteLine();

                    goto Start;
                }
                
            }

            //  var randomize = rng.Next(0, ballArray.Length -1);

            // Console.WriteLine($"{ ballArray[randomize] }");

            










        }
    }
}
