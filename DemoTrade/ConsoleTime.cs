using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DemoTrade
{
    public class ConsoleTime
    {

        public string realTime;
        string ExchangeTime;


        public void inputRealTime()
        {
            while (true)
            {
                
                realTime = DateTime.Now.ToLongTimeString();
                ExchangeTime = DateTime.UtcNow.ToLongTimeString();
                inputTimeInWorkBase();
                Thread.Sleep(1000);
            }

        }

        public void threadStartRealTime()
        {
            Thread thread = new Thread(inputRealTime);
            thread.Start();
        }

        public void inputTimeInWorkBase()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(15, 25);
            Console.Write(realTime);
            Console.SetCursorPosition(15, 28);
            Console.Write(ExchangeTime);
        }
    }
}
