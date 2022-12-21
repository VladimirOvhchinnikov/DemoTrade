using System;
using System.Collections.Generic;
using System.Text;

namespace DemoTrade.ConsoleWorks
{
    class jsonParser
    {
        Dictionary<int, string> resultSymbolprice;
        Dictionary<int, string> resultSymbol;
        Dictionary<int, string> resultProcent;
        internal void parserStringPricesJson(string price)
        {
            int lastIndex_1; /*индекс {*/
            int lastIndex_2; /*индекс }*/
            int lastIndex_3; /*индекс ,*/
            int lastIndex_4; /*индекс :*/
            int lastIndex_5; /*индекс :*/
            int indexDictionary = 1; /*индексатор словарей*/

            /*формат данных в словаре [{"symbol": "ETHBTC","price": "0.07212600"}, */
            Dictionary<int, string> resultBreakdowns = new Dictionary<int, string>();

            /*формат данных в словаре [{"symbol": "ETHBTC"*/
            Dictionary<int, string> symbol = new Dictionary<int, string>();

            /*формат данных в словаре "price": "0.07212600"}, */
            Dictionary<int, string> symbolprice = new Dictionary<int, string>();

            /*формат данных в словаре ETHBTC */
            resultSymbol = new Dictionary<int, string>();

            /*формат данных в словаре 0.07212600 */
            resultSymbolprice = new Dictionary<int, string>();

            while (true)
            {
                lastIndex_1 = price.IndexOf("{");
                lastIndex_2 = price.IndexOf("}");

                if (lastIndex_1 == -1 || lastIndex_2 == -1)
                {
                    break;
                }

                resultBreakdowns.Add(indexDictionary, price.Substring(lastIndex_1, lastIndex_2));

                lastIndex_3 = resultBreakdowns[indexDictionary].IndexOf(",");

                symbol.Add(indexDictionary, resultBreakdowns[indexDictionary].Substring(0, lastIndex_3));
                symbolprice.Add(indexDictionary, resultBreakdowns[indexDictionary].Substring(lastIndex_3, resultBreakdowns[indexDictionary].Length - lastIndex_3));

                lastIndex_4 = symbol[indexDictionary].IndexOf(":");
                lastIndex_5 = symbolprice[indexDictionary].IndexOf(":");

                resultSymbol.Add(indexDictionary, symbol[indexDictionary].Substring(lastIndex_4 + 2, symbol[indexDictionary].Length - lastIndex_4 - 3));
                resultSymbolprice.Add(indexDictionary, symbolprice[indexDictionary].Substring(lastIndex_5 + 2, symbolprice[indexDictionary].Length - lastIndex_5 - 5));

                indexDictionary++;
                price = price.Remove(lastIndex_1, lastIndex_2);
            }
        }

        internal void parserStringProcentJson()
        {
            DemoTrade.Binance binance = new Binance();
           string procent24hr=binance.WebRequestProcent24hr();

            int lastIndex_1; /*индекс {*/
            int lastIndex_2; /*индекс }*/
            int lastindex_3;
            int lastindex_4;

            /*формат данных в словаре [{"symbol":"ETHBTC","priceChange":"0.00010800",....}, */
            Dictionary<int, string> resultBreakdownss = new Dictionary<int, string>();
            Dictionary<int, string> resultProcent24hr = new Dictionary<int, string>();
            int indexDictionary = 1;

            while (true)
            {
                lastIndex_1 = procent24hr.IndexOf("{");
                lastIndex_2 = procent24hr.IndexOf("}");

                if (lastIndex_1 == -1 || lastIndex_2 == -1)
                {
                    break;
                }

                resultBreakdownss.Add(indexDictionary, procent24hr.Substring(lastIndex_1, lastIndex_2));
                lastindex_3 = resultBreakdownss[indexDictionary].LastIndexOf("priceChangePercent");
                resultBreakdownss[indexDictionary] = resultBreakdownss[indexDictionary].Substring(lastindex_3, 35);
                lastindex_4 = resultBreakdownss[indexDictionary].LastIndexOf(",");
                resultBreakdownss[indexDictionary] = resultBreakdownss[indexDictionary].Substring(21, lastindex_4 - 22);



                procent24hr = procent24hr.Remove(lastIndex_1, lastIndex_2);

                Console.WriteLine(resultBreakdownss[indexDictionary]);

                indexDictionary++;
            }

            Console.WriteLine("dg");
        }
    }
}
