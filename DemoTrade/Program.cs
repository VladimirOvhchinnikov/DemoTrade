using System;
using HashLib;

namespace DemoTrade
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Console.SetWindowSize(80,26);
            //User user = new User();

            MenuMain main = new MenuMain();
            main.OutputMenuMain();

            SqLite sqLite = new SqLite();
            sqLite.Connection();


            
          
        }
    }
}
