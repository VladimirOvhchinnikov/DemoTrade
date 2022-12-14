using System;
using System.Collections.Generic;
using System.Text;

namespace DemoTrade
{
    class MenuRegistration : MenuBasic
    {
        Point pointArrowLogin = new Point(0, 0);
        Point pointLogin = new Point(10, 0);
        Point inputLogin = new Point(13, 0);

        Point pointArrowPassword = new Point(0, 1);
        Point pointPassword = new Point(10, 1);
        Point inputPassword = new Point(13, 1);

        Point pointArrowName = new Point(0, 2);
        Point pointName = new Point(10, 2);
        Point inputName = new Point(13, 2);

        Point pointArrowSurname = new Point(0, 3);
        Point pointSurname = new Point(10, 3);
        Point inputSurname = new Point(13, 3);

        Point pointRegistration = new Point(0, 4);

        ConsoleColor colorLogin = ConsoleColor.Yellow;
        ConsoleColor colorPassword = ConsoleColor.Yellow;
        ConsoleColor colorName = ConsoleColor.Yellow;
        ConsoleColor colorSurname = ConsoleColor.Yellow;
        ConsoleColor colorRegistration = ConsoleColor.Red;


        internal void InputStart()
        {
            Console.Clear();
            outputString("Login    -> ", colorLogin, pointLogin);
            outputString(arrow, ConsoleColor.Yellow, pointArrowLogin);

            outputString("Password -> ", colorPassword, pointPassword);
            outputString(arrow, ConsoleColor.Yellow, pointArrowPassword);

            outputString("Name     -> ", colorName, pointName);
            outputString(arrow, ConsoleColor.Yellow, pointArrowName);

            outputString("Surname  -> ", colorSurname, pointSurname);
            outputString(arrow, ConsoleColor.Yellow, pointArrowSurname);

            outputString("Registration", colorRegistration, pointRegistration);
        }

        private int MoveMenu(int numberPosition)
        {
            InputStart();

            ConsoleKeyInfo keyInfo;

            while (true)
            {

            }

            return 0;
        }
    }
}
