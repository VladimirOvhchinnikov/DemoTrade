using System;
using System.Collections.Generic;
using System.Text;

namespace DemoTrade
{
    class MenuBasic
    { 
       internal const string arrow = "--->>>";

        internal void outputString(string outputStr, ConsoleColor color, Point point)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(point.coordinateX, point.coordinateY);
            Console.Write(outputStr);
        }
    }

}
