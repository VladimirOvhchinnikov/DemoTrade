using System;
using System.Collections.Generic;
using System.Text;

namespace DemoTrade.ConsoleWork
{
    class ConsoleWorkBase
    {
        //Свойства класса
        private readonly Dictionary<int, string> nameAssets = new Dictionary<int, string>()
        {
            /*Сделать выгрузку из баззы данных*/
            {0, "BTC"},
            {1, "ETH"},
            {2, "ETC"},
            {3, "ZIL"},
            {4, "BNB"},
            {5, "SOL"},
            {6, "LTC"},
            {7, "TWT"},

        };
        private readonly Dictionary<int, Point> pointASsets = new Dictionary<int, Point>();
        private readonly Dictionary<int, string> namePrice = new Dictionary<int, string>();

        private readonly Dictionary<int, Point> pointPrice = new Dictionary<int, Point>();
        private readonly Dictionary<int, string> nameAssetsPrice = new Dictionary<int, string>();

        private readonly Dictionary<int, Point> pointAssetsProcent = new Dictionary<int, Point>();
        
        private readonly Dictionary<int, Point> pointAssetsLine = new Dictionary<int, Point>();
        private readonly Dictionary<int, string> nameButton = new Dictionary<int, string>()
        {
            {0, "************************"},
            {1, "*" }
        };

        //Конструткор класса
        public ConsoleWorkBase()
        {
            GenerationWorkBase();
        }


        /*Генерация первичного статичного окна*/
        private void GenerationWorkBase()
        {
            Console.Clear();
            Console.SetWindowSize(150, 30);

            /*Генерация словаря активов окна и его точек вывода*/
            GenerationDictionary(pointASsets, 3, 8, 2, 1);
            InputConsoleData(pointASsets, nameAssets);

            /*Генерация словаря цен и его точек ввода */
            GenerationDictionary(pointPrice, 3, 8, 6, 1);
            InputConsoleData(pointPrice, GenerationDictionary(namePrice, "0,00000", 8));

            /*Генерация словаря процентов и его точек вывода*/
            GenerationDictionary(pointAssetsProcent, 3, 8, 15, 1);
            InputConsoleData(pointAssetsProcent, GenerationDictionary(nameAssetsPrice, "  0.00%", 8));

            GenerationDictionary(pointAssetsLine, 1, 24, 0, 0);
            GenerationButtonWorkBase();
        }

        //Генерация однотипных строковых позиций для словаря
        private Dictionary<int, string> GenerationDictionary(Dictionary<int, string> dict, string inputLine, int length)
        {
            for (int i = 0; i < length; i++)
            {
                dict.Add(i, inputLine);
            }

            return dict;
        }

        //Генерация словаря с точками с одинаковым интервалом 
        private Dictionary<int,Point> GenerationDictionary(Dictionary<int, Point> dict, int pointDistance, int length, int startPositionX, int startPositionY)
        {
            int pointDistanceAmount=0;
            for(int i =0; i < length; i++)
            {
                dict.Add(i, new Point(startPositionX, startPositionY + pointDistanceAmount));
                pointDistanceAmount = pointDistanceAmount + pointDistance;
            }

            return dict;
        }

        // Метод для вывода консольных данных. Перегрузка для Словарей
        private void InputConsoleData(Dictionary<int,Point> pointInformation, Dictionary<int, string> inputInformation)
        {
            try
            {
                for (int i = 0; i < pointInformation.Count; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(pointInformation[i].coordinateX, pointInformation[i].coordinateY);
                    Console.WriteLine(inputInformation[i]);
                }
            }
            catch(IndexOutOfRangeException) when ( pointInformation.Count != inputInformation.Count)
            {
                Console.WriteLine("Длины библиотек не совпадают");
            }

        }

        /*Генерация статичных кнопок выбора монет*/
        private void GenerationButtonWorkBase()
        {

            for(int i=0; i<22; i+=3)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.SetCursorPosition(pointAssetsLine[i].coordinateX, pointAssetsLine[i].coordinateY);
                Console.WriteLine(nameButton[0]);

                Console.SetCursorPosition(pointAssetsLine[1].coordinateX, pointAssetsLine[i + 1].coordinateY);
                Console.WriteLine(nameButton[1]);

                Console.SetCursorPosition(pointAssetsLine[ 1].coordinateX+23, pointAssetsLine[i + 1].coordinateY);
                Console.WriteLine(nameButton[1]);

                Console.SetCursorPosition(pointAssetsLine[i + 2].coordinateX, pointAssetsLine[i + 2].coordinateY);
                Console.WriteLine(nameButton[0]);

            }
        }
    }
}
