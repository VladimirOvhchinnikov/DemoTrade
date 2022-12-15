using System;
using System.Collections.Generic;
using System.Text;

namespace DemoTrade
{
    class MenuRegistration : MenuBasic
    {
        
        public void MoveMenu()
        {
            Console.Clear();
            User user = new User();
            ConsoleKeyInfo keyInfo;
            int numberPosition = 0;
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

                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    if (numberPosition == 0)
                    {
                        Console.SetCursorPosition(inputLogin.coordinateX + 9, inputLogin.coordinateY);
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
                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    MenuMain menuMain = new MenuMain();
                    menuMain.OutputMenuMain();
                }

                EnterColor(numberPosition);
            }
        }

        private void EnterColor(int numberPosition)
        {
            colorLogin = ConsoleColor.Yellow;
            colorPassword = ConsoleColor.Yellow;
            colorName = ConsoleColor.Yellow;
            colorSurname = ConsoleColor.Yellow;
            colorRegistration = ConsoleColor.Red;

            if (numberPosition == 0)
            {
                colorLogin = ConsoleColor.Gray;
            }
            else if (numberPosition == 1)
            {
                colorPassword = ConsoleColor.Gray;
            }
            else if (numberPosition == 3)
            {
                colorSurname = ConsoleColor.Gray;
            }
            else if (numberPosition == 4)
            {
                colorRegistration = ConsoleColor.Green;
            }
        }
    }
}


