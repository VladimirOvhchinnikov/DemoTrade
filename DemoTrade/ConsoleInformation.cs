using System;
using System.Collections.Generic;
using System.Text;

namespace DemoTrade
{
    class ConsoleInformation
    {
        private const string arrow = "--->>>";
        

        public void outputmainMenu()
        {
            string
                textSignUp = " Sign up ",
                textLogIn = " Log in ";

            Point pointSignUp = new Point(6,0);
            Point pointLogIn = new Point(6, 1);
            Point pointArrowSignUp = new Point(0, 0);
            Point pointArrowLogIn = new Point(0, 1);

            outputString(arrow, ConsoleColor.Yellow, pointArrowSignUp);
            outputString(textSignUp, ConsoleColor.Red, pointSignUp);

            outputString(arrow, ConsoleColor.Yellow, pointArrowLogIn);
            outputString(textLogIn, ConsoleColor.White, pointLogIn);

            ConsoleKeyInfo keyInfo;
            int redPosition = 0;

            do
            {
                keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.DownArrow) 
                {
                    if (redPosition == 0)
                    {
                        redPosition = 1;
                    }
                    else if (redPosition == 1)
                    {
                        redPosition = 0;
                    }
                }

                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    if (redPosition == 0)
                    {
                        redPosition = 1;
                    }
                    else if (redPosition == 1)
                    {
                        redPosition = 0;
                    }
                }

                if(redPosition == 0)
                {
                    outputString(textSignUp, ConsoleColor.Red, pointSignUp);
                    outputString(textLogIn, ConsoleColor.White, pointLogIn);
                }


                if (redPosition == 1)
                {
                    outputString(textSignUp, ConsoleColor.White, pointSignUp);
                    outputString(textLogIn, ConsoleColor.Red, pointLogIn);
                }

                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    if (redPosition == 0)
                    {
                        outputRegistrWindow();
                    }
                    if (redPosition == 1)
                    {
                        //
                    }
                }

            } while (keyInfo.Key != ConsoleKey.Escape);

           
            Environment.Exit(0);
        }

      

        private void outputRegistrWindow() 
        {
            Console.Clear();
        }


        // вывод информации в консоль
        private void outputString(string outputStr, ConsoleColor color, Point point)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(point.coordinateX, point.coordinateY);
            Console.Write(outputStr);
        }
    }
}
