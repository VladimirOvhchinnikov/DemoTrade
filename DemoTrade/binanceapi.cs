using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Threading;

namespace DemoTrade
{
    class binanceapi
    {
        string urlPrice = @"https://api.binance.com/api/v3/ticker/price?symbol=";

        string btcusdt = "BTCUSDT";

        public string getRequest(string Money)
        {
                System.Net.WebRequest request = System.Net.WebRequest.Create(urlPrice + Money);
                System.Net.WebResponse resp = request.GetResponse();
                System.IO.Stream stream = resp.GetResponseStream();
                System.IO.StreamReader sr = new System.IO.StreamReader(stream);
                string symbolPrice = sr.ReadToEnd();
            

            return symbolPrice;
        }
    
    
        public string inputPriceinConsole()
        {
            string symbolPrice = getRequest(btcusdt);
            string[] arrsplit = symbolPrice.Split(',');
            arrsplit[1] = arrsplit[1].Substring(9, 9);

            return arrsplit[1];
        }

        public void inputPrice()
        {
            while (true)
            {
                Console.SetCursorPosition(6, 1);
                Console.Write(inputPriceinConsole());
                

                Console.SetCursorPosition(6, 4);
                Console.Write(inputPriceinConsole());

                Console.SetCursorPosition(6, 7);
                Console.Write(inputPriceinConsole());


                Console.SetCursorPosition(6, 10);
                Console.Write(inputPriceinConsole());


                Thread.Sleep(20000);
            }
          
        }
       

        public void threadStartPrice()
        {
            Thread thread = new Thread(inputPrice);
            thread.Start();
            
         
        }
    }
}
