using System;
using System.Collections.Generic;
using System.Text;

namespace DemoTrade.ConsoleWorks
{
    class ConsoleWorkBases

    {
        Dictionary<int, Dictionary<int, string>> searchPositions = new Dictionary<int, Dictionary<int, string>>();

        /*Получение информации от биржи*/
        jsonParser parser = new jsonParser();
        Binance binance = new Binance();

        /*Стандартный блок для кнопок*/
        readonly Dictionary<int, string> blockSymbol = new Dictionary<int, string>()
        {
            {1,"*********************************"},
            {2,"*    *"},
            {3,"*********************************" }
        };

        /*Инициализатор класса*/
        internal ConsoleWorkBases()
        {
            

            parser.parserStringPricesJson(binance.WebRequestPrice());
            parser.parserStringProcentJson(binance.WebRequestProcent24hr());

            inputFirst();
        }

        /*Вывод первичной формы окна*/
        internal void inputFirst()
        {
            inputButtonSearch(ConsoleColor.Gray);
            inputNullBlockSymbol();
            inputButtonNext(ConsoleColor.Gray);

            moveMenu();
        }

        /*Метод движения по основному окну*/
        internal void moveMenu()
        {
            int positionCursor = 0;

            
            ConsoleKeyInfo key;
            while (true)
            {
                int positionmenu = 20;
                key = Console.ReadKey();

                if (positionCursor == 0)
                {
                    inputButtonSearch(ConsoleColor.Green);
                }

                if(positionCursor == 0 && key.Key == ConsoleKey.Enter)
                {
                    clickButtonSearch();
                }
                positionCursor = 1;

                if (positionCursor == 1 && key.Key == ConsoleKey.Enter)
                {
                    clickButtonSearch();
                    positionmenu = positionmenu + 20;
                }
            }
        }

        /*Метод действия при нажатии на кнопку поиска*/
        internal void clickButtonSearch()
        {
            Console.SetCursorPosition(15, 1);
            string strSearch = Console.ReadLine();
            Search search = new Search();

            /*Запрашвиаем метод создания блоков с информацией*/
            creatingBlocksInformation(search.searchSymbolPosition(parser.resultSymbol, strSearch), parser.resultSymbol, parser.resultSymbolprice, parser.resultProcent);
           
        }

        /*Метод сохранения  блоков с именем монеты, цены, процента в словарь инт, словарь инт,стринг*/
        internal void creatingBlocksInformation(Dictionary<int,int> keySymbol, Dictionary<int,string> symbol, Dictionary<int,string> price, Dictionary<int,string> procent) 
        {
            Dictionary<int, Dictionary<int,string>> searchPosition = new Dictionary<int, Dictionary<int, string>>();

            for(int i=1; i<keySymbol.Count; i++)
            {
              searchPosition.Add(i,inputSymbol(symbol[keySymbol[i]], price[keySymbol[i]], procent[keySymbol[i]]));
            }
            searchPositions = new Dictionary<int, Dictionary<int, string>>(searchPosition);
            inputBlockSymbol(searchPosition,1);
        }

        /*Метод генерации блоков с ценой, процентом, и именем монеты */
        internal Dictionary<int,string> inputSymbol(string symbol, string price, string procent)
        {
            Dictionary<int, string> blockSymbolCopy =new Dictionary<int, string>(blockSymbol);

            blockSymbolCopy[2] = blockSymbolCopy[2].Insert(2, symbol);
            blockSymbolCopy[2] = blockSymbolCopy[2].Insert(blockSymbolCopy[2].IndexOf(symbol[symbol.Length-1])+2, price);
            blockSymbolCopy[2] = blockSymbolCopy[2].Insert(blockSymbolCopy[2].LastIndexOf(price[price.Length - 1]) + 2, procent);
            for (int i=0; blockSymbolCopy[2].Length < blockSymbolCopy[1].Length; i++)
            {
                blockSymbolCopy[2] = blockSymbolCopy[2].Insert(blockSymbolCopy[2].LastIndexOf(" ")," ");

            }

            return blockSymbolCopy;
        }

        /*Вывод кнопки поиска*/
        private void inputButtonSearch(ConsoleColor color)
        {
            Dictionary<int, string> blockButtonSearch = new Dictionary<int, string> (blockSymbol);
            blockButtonSearch[2] = "* SEARCH ->>                    *";

            Console.ForegroundColor = color;
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(blockButtonSearch[1]);
            Console.SetCursorPosition(0, 1);
            Console.WriteLine(blockButtonSearch[2]);
            Console.SetCursorPosition(0, 2);
            Console.WriteLine(blockButtonSearch[3]);
        }

        /*Вывод кнопки Следующей страницы*/
        private void inputButtonNext(ConsoleColor color) 
        {
            Dictionary<int, string> blockButtonSearch = new Dictionary<int, string>(blockSymbol);
            blockButtonSearch[2] = "*            NEXT               *";

            Console.SetCursorPosition(40, 0);
            Console.WriteLine(blockButtonSearch[1]);
            Console.SetCursorPosition(40, 1);
            Console.WriteLine(blockButtonSearch[2]);
            Console.SetCursorPosition(40, 2);
            Console.WriteLine(blockButtonSearch[3]);

        }

        private void inputBlockSymbol(Dictionary<int,Dictionary<int,string>> symbol, int position)
        {
            int cursorPositionX = 0;
            int cursorPositionY = 5;

            //Dictionary<int, string> blockNullSymbol = new Dictionary<int, string>(blockSymbol);
            //blockNullSymbol[2] = "*                               *";

            for (int i = 1; i < 11; i++)
            {
                Console.SetCursorPosition(cursorPositionX, cursorPositionY);
                Console.Write(symbol[position+i][1]);
                Console.SetCursorPosition(cursorPositionX, cursorPositionY + 1);
                Console.Write(symbol[position + i][2]);
                Console.SetCursorPosition(cursorPositionX, cursorPositionY + 2);
                Console.Write(symbol[position + i][3]);
                cursorPositionY = cursorPositionY + 4;
            }

            cursorPositionX = 40;
            cursorPositionY = 5;

            for (int i = 12; i < 22; i++)
            {
                Console.SetCursorPosition(cursorPositionX, cursorPositionY);
                Console.Write(symbol[position + i][1]);
                Console.SetCursorPosition(cursorPositionX, cursorPositionY + 1);
                Console.Write(symbol[position + i][2]);
                Console.SetCursorPosition(cursorPositionX, cursorPositionY + 2);
                Console.Write(symbol[position + i][3]);
                cursorPositionY = cursorPositionY + 4;
            }
        }

        private void inputNullBlockSymbol()
        {
            int cursorPositionX = 0;
            int cursorPositionY = 5;

            Dictionary<int, string> blockNullSymbol = new Dictionary<int, string>(blockSymbol);
            blockNullSymbol[2] = "*                               *";

            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(cursorPositionX, cursorPositionY);
                Console.Write(blockNullSymbol[1]);
                Console.SetCursorPosition(cursorPositionX, cursorPositionY+1);
                Console.Write(blockNullSymbol[2]);
                Console.SetCursorPosition(cursorPositionX, cursorPositionY+2);
                Console.Write(blockNullSymbol[3]);
                cursorPositionY = cursorPositionY + 4; 
            }

            cursorPositionX = 40;
            cursorPositionY = 5;

            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(cursorPositionX, cursorPositionY);
                Console.Write(blockNullSymbol[1]);
                Console.SetCursorPosition(cursorPositionX, cursorPositionY+1);
                Console.Write(blockNullSymbol[2]);
                Console.SetCursorPosition(cursorPositionX, cursorPositionY+2);
                Console.Write(blockNullSymbol[3]);
                cursorPositionY = cursorPositionY + 4;
            }
        }

        private void clickButtonNext( int position)
        {
            inputButtonNext(ConsoleColor.Green);
            Dictionary<int, Dictionary<int, string>> dict = new Dictionary<int, Dictionary<int, string>>(searchPositions);

            inputBlockSymbol(dict, position);

        }
    }
}
