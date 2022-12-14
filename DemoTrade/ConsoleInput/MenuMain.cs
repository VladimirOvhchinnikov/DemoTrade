using System;
using System.Collections.Generic;
using System.Text;

namespace DemoTrade
{
    class MenuMain : MenuBasic
    {
        private readonly string textSignUp = " Sign up ";
        private readonly string textLogIn = " Log in ";
        ConsoleKeyInfo keyInfo;
        //int redPosition = 0;

        Point pointSignUp = new Point(6, 0);
        Point pointLogIn = new Point(6, 1);
        Point pointArrowSignUp = new Point(0, 0);
        Point pointArrowLogIn = new Point(0, 1);



        private void InputStart()
        {
            outputString(arrow, ConsoleColor.Yellow, pointArrowSignUp);
            outputString(textSignUp, ConsoleColor.Red, pointSignUp);

            outputString(arrow, ConsoleColor.Yellow, pointArrowLogIn);
            outputString(textLogIn, ConsoleColor.White, pointLogIn);
        }

        private int MoveMenu(int redPosition)
        {
            keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.DownArrow || keyInfo.Key == ConsoleKey.UpArrow)
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

            if (keyInfo.Key == ConsoleKey.Enter)
            {
                if (redPosition == 0)
                {
                    //
                }
                if (redPosition == 1)
                {
                    // sign
                }
            }

            return redPosition;
        }

        public void OutputMenuMain()
        {
            int redPosition = 0;
            InputStart();
            while (true)
            {
                redPosition = MoveMenu(redPosition);
                if (redPosition == 0)
                {
                    outputString(textSignUp, ConsoleColor.Red, pointSignUp);
                    outputString(textLogIn, ConsoleColor.White, pointLogIn);
                }


                if (redPosition == 1)
                {
                    outputString(textSignUp, ConsoleColor.White, pointSignUp);
                    outputString(textLogIn, ConsoleColor.Red, pointLogIn);
                }
            }

        }

    }
}
