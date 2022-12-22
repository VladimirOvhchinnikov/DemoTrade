using System;
using System.Collections.Generic;
using System.Text;

namespace DemoTrade.ConsoleWorks
{
    class Search
    {
        internal Dictionary<int, int> searchSymbolPosition(Dictionary<int, string> dctSymbol, string searchSymbol)
        {
            Dictionary<int, int> positionSymbol = new Dictionary<int, int>();

            int key = 1;

            for (int i = 1; i < dctSymbol.Count; i++)
            {
                if (dctSymbol[i].IndexOf(searchSymbol) != -1)
                {
                    positionSymbol.Add(key, i);
                    key++;
                }
            }

            return positionSymbol;
        }

       
    }
}
