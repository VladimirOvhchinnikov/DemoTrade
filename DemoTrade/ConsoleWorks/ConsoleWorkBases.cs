using System;
using System.Collections.Generic;
using System.Text;

namespace DemoTrade.ConsoleWorks
{
    class ConsoleWorkBases
    {
        readonly Dictionary<int, string> blockSymbol = new Dictionary<int, string>()
        {
            {1,"*********************************"},
            {2,"*    *"},
            {3,"*********************************" }
        };

        internal Dictionary<int,string> inputSymbol(string symbol, string price, string procent)
        {
            Dictionary<int, string> blockSymbolCopy = blockSymbol;

            blockSymbolCopy[2] = blockSymbolCopy[2].Insert(2, symbol);
            blockSymbolCopy[2] = blockSymbolCopy[2].Insert(blockSymbolCopy[2].IndexOf(symbol[symbol.Length-1])+2, price);
            blockSymbolCopy[2] = blockSymbolCopy[2].Insert(blockSymbolCopy[2].LastIndexOf(price[price.Length - 1]) + 2, procent+"%");
            for (int i=0; blockSymbolCopy[2].Length < blockSymbolCopy[1].Length; i++)
            {
                blockSymbolCopy[2] = blockSymbolCopy[2].Insert(blockSymbolCopy[2].LastIndexOf(" ")," ");

            }

            Console.WriteLine(blockSymbolCopy[1]);
            Console.WriteLine(blockSymbolCopy[2]);
            Console.WriteLine(blockSymbolCopy[3]);

            return blockSymbolCopy;
        }


    }
}
