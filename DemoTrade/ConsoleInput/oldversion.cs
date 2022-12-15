using System;
using System.Collections.Generic;
using System.Text;

namespace DemoTrade
{
    class oldversion
    {
        User user = new User();
        private const string arrow = "--->>>";
        
        public void OutputmainMenu()
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
                        OutputRegistrWindow();
                    }
                    if (redPosition == 1)
                    {
                        // sign
                    }
                }

            } while (keyInfo.Key != ConsoleKey.Escape);

           
            Environment.Exit(0);
        }

        private void OutputRegistrWindow() 
        {
            Console.Clear();

            Point pointArrowLogin = new Point(0, 0);
            Point pointLogin = new Point(10, 0);
            Point inputLogin = new Point(13,0);

            Point pointArrowPassword = new Point(0, 1);
            Point pointPassword = new Point(10, 1);
            Point inputPassword = new Point(13, 1);

            Point pointArrowName = new Point(0, 2);
            Point pointName = new Point(10, 2);
            Point inputName = new Point(13, 2);

            Point pointArrowSurname = new Point(0, 3);
            Point pointSurname = new Point(10, 3);
            Point inputSurname = new Point(13, 3);

            Point pointRegistration= new Point(0, 4);

            ConsoleColor colorLogin = ConsoleColor.Yellow;
            ConsoleColor colorPassword = ConsoleColor.Yellow;
            ConsoleColor colorName = ConsoleColor.Yellow;
            ConsoleColor colorSurname = ConsoleColor.Yellow;
            ConsoleColor colorRegistration = ConsoleColor.Red;

            ConsoleKeyInfo keyInfo;
            int numberPosition =0;
            while (true)
            {
                outputString("Login    -> ", colorLogin, pointLogin);
                outputString(arrow, ConsoleColor.Yellow, pointArrowLogin);

                outputString("Password -> ", colorPassword, pointPassword);
                outputString(arrow, ConsoleColor.Yellow, pointArrowPassword);

                outputString("Name     -> ", colorName, pointName);
                outputString(arrow, ConsoleColor.Yellow, pointArrowName);

                outputString("Surname  -> ", colorSurname, pointSurname);
                outputString(arrow, ConsoleColor.Yellow, pointArrowSurname);

                outputString("Registration", colorRegistration, pointRegistration);

                keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    if (numberPosition == 4)
                    {
                        numberPosition = 0;
                    }
                    else numberPosition++;
                }
                 
                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    if (numberPosition == 0)
                    {
                        numberPosition = 4;
                    }
                    else numberPosition--;
                } 

                if(keyInfo.Key == ConsoleKey.Enter) 
                {
                    if(numberPosition == 0) 
                    {
                        Console.SetCursorPosition(inputLogin.coordinateX+9, inputLogin.coordinateY);
                        user.Login = Console.ReadLine();
                    }
                    if (numberPosition == 1)
                    {
                        Console.SetCursorPosition(inputPassword.coordinateX + 9, inputPassword.coordinateY);
                        user.Password = Console.ReadLine();
                    }
                    if (numberPosition == 2)
                    {
                        Console.SetCursorPosition(inputName.coordinateX + 9, inputName.coordinateY);
                        user.Name = Console.ReadLine();
                    }
                    if (numberPosition == 3)
                    {
                        Console.SetCursorPosition(inputSurname.coordinateX + 9, inputSurname.coordinateY);
                        user.Surname = Console.ReadLine();
                    }
                }

                if(numberPosition == 0)
                {
                    colorLogin = ConsoleColor.Gray;
                    colorPassword = ConsoleColor.Yellow;
                    colorName = ConsoleColor.Yellow;
                    colorSurname = ConsoleColor.Yellow;
                    colorRegistration = ConsoleColor.Red;
                }
                if (numberPosition == 1)
                {
                    colorLogin = ConsoleColor.Yellow;
                    colorPassword = ConsoleColor.Gray;
                    colorName = ConsoleColor.Yellow;
                    colorSurname = ConsoleColor.Yellow;
                    colorRegistration = ConsoleColor.Red;
                }
                if (numberPosition == 2)
                {
                    colorLogin = ConsoleColor.Yellow;
                    colorPassword = ConsoleColor.Yellow;
                    colorName = ConsoleColor.Gray;
                    colorSurname = ConsoleColor.Yellow;
                    colorRegistration = ConsoleColor.Red;
                }
                if (numberPosition == 3)
                {
                    colorLogin = ConsoleColor.Yellow;
                    colorPassword = ConsoleColor.Yellow;
                    colorName = ConsoleColor.Yellow;
                    colorSurname = ConsoleColor.Gray;
                    colorRegistration = ConsoleColor.Red;
                }
                if (numberPosition == 4)
                {
                    colorLogin = ConsoleColor.Yellow;
                    colorPassword = ConsoleColor.Yellow;
                    colorName = ConsoleColor.Yellow;
                    colorSurname = ConsoleColor.Yellow;
                    colorRegistration = ConsoleColor.Green;
                }
            }
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
