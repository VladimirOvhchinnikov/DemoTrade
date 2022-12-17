using System;
using System.Collections.Generic;
using System.Text;

namespace DemoTrade
{
    class MenuBasic
    {
        internal const string arrow = "--->>>";

        internal readonly Point pointArrowLogin = new Point(0, 0);
        internal readonly Point pointLogin = new Point(10, 0);
        internal readonly Point inputLogin = new Point(13, 0);

        internal readonly Point pointArrowPassword = new Point(0, 1);
        internal readonly Point pointPassword = new Point(10, 1);
        internal readonly Point inputPassword = new Point(13, 1);

        internal readonly Point pointArrowName = new Point(0, 2);
        internal readonly Point pointName = new Point(10, 2);
        internal readonly Point inputName = new Point(13, 2);

        internal readonly Point pointArrowSurname = new Point(0, 3);
        internal readonly Point pointSurname = new Point(10, 3);
        internal readonly Point inputSurname = new Point(13, 3);

        internal readonly Point pointRegistration = new Point(0, 4);
        internal readonly Point pointSign = new Point(0, 2);

        internal ConsoleColor colorLogin = ConsoleColor.Yellow;
        internal ConsoleColor colorPassword = ConsoleColor.Yellow;
        internal ConsoleColor colorName = ConsoleColor.Yellow;
        internal ConsoleColor colorSurname = ConsoleColor.Yellow;
        internal ConsoleColor colorRegistration = ConsoleColor.Red;
        internal ConsoleColor colorSign = ConsoleColor.Red;

        internal void outputString(string outputStr, ConsoleColor color, Point point)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(point.coordinateX, point.coordinateY);
            Console.Write(outputStr);
        }
    }

}
