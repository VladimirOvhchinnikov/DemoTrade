using System;
using HashLib;
using System.Data.SQLite;
using DemoTrade.ConsoleWork;
using Binance.Net;
using Binance.Net.Clients.SpotApi;
using DemoTrade.ConsoleWorks;

namespace DemoTrade
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Console.SetWindowSize(80,26);
            //User user = new User();

            // MenuMain main = new MenuMain();
            // main.OutputMenuMain();

            //ConsoleWorkBase consoleWorkBase = new ConsoleWorkBase();

            //binanceapi binanceapi = new binanceapi();
            //binanceapi.inputPriceinConsole();


            //Binance binance = new Binance();
            //binance.parserStringPricesJson(binance.getRequest());

            //ConsoleWorkBases workBases = new ConsoleWorkBases();
            //workBases.inputSymbol("ETHwBTC", "0.07212600", "0.168");
            //jsonParser jsonParser = new jsonParser();
            //jsonParser.parserStringProcentJson();

            ConsoleWorkBases consoleWorkBases = new ConsoleWorkBases();
           
        }
    }
}
