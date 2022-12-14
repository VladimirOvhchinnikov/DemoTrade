using DemoTrade.ConsoleWork;
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

                numberPosition = enterPositionMenu(numberPosition, 2, keyInfo);

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

                    if(numberPosition == 2)
                    {
                        Hash hash = new Hash();
                        user = hash.hashingUser(user);
                        SqLite sqLite = new SqLite();
                        sqLite.Connection();

                        if (sqLite.SearchData(user.Login, "login") == true &&
                             sqLite.SearchData(user.Password, "Password") == true)
                        {
                            ConsoleWorkBase workBase = new ConsoleWorkBase();
                        }

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
