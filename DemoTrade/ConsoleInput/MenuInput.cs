using System;
using System.Collections.Generic;
using System.Text;

namespace DemoTrade.ConsoleInput
{
    class MenuInput : MenuBasic
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

                outputString("Sign", colorSign, pointSign);

                keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    if (numberPosition == 2)
                    {
                        numberPosition = 0;
                    }
                    else numberPosition++;
                }

                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    if (numberPosition == 0)
                    {
                        numberPosition = 2;
                    }
                    else numberPosition--;
                }

                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    if (numberPosition == 0)
                    {
                        Console.SetCursorPosition(inputLogin.coordinateX + 9, inputLogin.coordinateY);
                        user.login = Console.ReadLine();
                    }
                    if (numberPosition == 1)
                    {
                        Console.SetCursorPosition(inputPassword.coordinateX + 9, inputPassword.coordinateY);
                        user.password = Console.ReadLine();
                    }

                }
                if(keyInfo.Key == ConsoleKey.Escape)
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
            colorSign = ConsoleColor.Red;

            if (numberPosition == 0)
            {
                colorLogin = ConsoleColor.Gray;
            }
            else if (numberPosition == 1)
            {
                colorPassword = ConsoleColor.Gray;
            } else if(numberPosition == 2)
            {
                colorSign = ConsoleColor.Green;
            }
        }
    }

}
