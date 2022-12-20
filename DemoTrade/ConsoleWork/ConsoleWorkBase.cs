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

        /*Словарь точек и словарь название активов*/
        private readonly Dictionary<int, Point> pointASsets = new Dictionary<int, Point>();
        private readonly Dictionary<int, string> namePrice = new Dictionary<int, string>();

        /*Словарь точек и словарь стоимости активов */
        private readonly Dictionary<int, Point> pointPrice = new Dictionary<int, Point>();
        private readonly Dictionary<int, string> nameAssetsPrice = new Dictionary<int, string>();

        /*Словарь точек и словарь процентов активов*/
        private readonly Dictionary<int, Point> pointAssetsProcent = new Dictionary<int, Point>();
        private readonly Dictionary<int, Point> pointAssetsLine = new Dictionary<int, Point>();

        /*Словарь визуального разделения информации в меню выбора монет*/
        private readonly Dictionary<int, string> nameButton = new Dictionary<int, string>()
        {
            {0, "************************"},
            {1, "*" }
        };

        /*Словарь визуального  разделения времени от меню*/
        private readonly Dictionary<int, Point> pointTime_1 = new Dictionary<int, Point>();
        private readonly Dictionary<int, Point> pointTime_2 = new Dictionary<int, Point>();
        private readonly Dictionary<int, string> nameTime_1 = new Dictionary<int, string>();
        private readonly Dictionary<int, string> nameTime_2 = new Dictionary<int, string>();

        //Конструткор класса
        public ConsoleWorkBase()
        {
            GenerationWorkBase();
            ConsoleTime time = new ConsoleTime();
            time.threadStartRealTime();
            /*Запуск меню */
            MoveButtonWorkBase();
           
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

            /*Генерация визуального разделения между названиями активов*/
            GenerationDictionary(pointAssetsLine, 1, 30, 0, 0);
            GenerationButtonWorkBase(0,28, ConsoleColor.Gray);

            /*Генерация словаря time*/
            GenerationDictionary(pointTime_1, 1, 1, 1, 25);
            InputConsoleData(pointTime_1, GenerationDictionary(nameTime_1, "general time  14:50:25", 8));

            GenerationDictionary(pointTime_2, 1, 1, 1, 28);
            InputConsoleData(pointTime_2, GenerationDictionary(nameTime_2, "exchange time 19:50:25", 8));
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

        /*Генерация статичных кнопок выбора монет   */
        private void GenerationButtonWorkBase(int startInput, int endInput, ConsoleColor color)
        {

            for(int i=startInput; i<endInput; i+=3)
            {
                Console.ForegroundColor = color;
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

        /*Движение по основному меню монет*/
        private void MoveButtonWorkBase()
        {
            int numberPosition = 0;
            MenuBasic menuBasic = new MenuBasic();

            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                numberPosition = menuBasic.enterPositionMenu(numberPosition, 7, keyInfo);

                if(numberPosition == 0)
                {
                    GenerationButtonWorkBase(0, 3, ConsoleColor.Green);
                    GenerationButtonWorkBase(3, 22, ConsoleColor.Gray);
                }

                if (numberPosition == 1)
                {
                    GenerationButtonWorkBase(0, 3, ConsoleColor.Gray);
                    GenerationButtonWorkBase(3, 5, ConsoleColor.Green);
                    GenerationButtonWorkBase(6, 22, ConsoleColor.Gray);
                }
                if (numberPosition == 2)
                {
                    GenerationButtonWorkBase(0, 6, ConsoleColor.Gray);
                    GenerationButtonWorkBase(6, 8, ConsoleColor.Green);
                    GenerationButtonWorkBase(9, 22, ConsoleColor.Gray);
                }
                if (numberPosition == 3)
                {
                    GenerationButtonWorkBase(0, 9, ConsoleColor.Gray);
                    GenerationButtonWorkBase(9, 11, ConsoleColor.Green);
                    GenerationButtonWorkBase(12, 22, ConsoleColor.Gray);
                }

                if (numberPosition == 4)
                {
                    GenerationButtonWorkBase(0, 12, ConsoleColor.Gray);
                    GenerationButtonWorkBase(12, 14, ConsoleColor.Green);
                    GenerationButtonWorkBase(15, 22, ConsoleColor.Gray);
                }

                if (numberPosition == 5)
                {
                    GenerationButtonWorkBase(0, 15, ConsoleColor.Gray);
                    GenerationButtonWorkBase(15, 17, ConsoleColor.Green);
                    GenerationButtonWorkBase(18, 22, ConsoleColor.Gray);
                }

                if (numberPosition == 6)
                {
                    GenerationButtonWorkBase(0, 18, ConsoleColor.Gray);
                    GenerationButtonWorkBase(18, 20, ConsoleColor.Green);
                    GenerationButtonWorkBase(21, 22, ConsoleColor.Gray);
                }

                if (numberPosition == 7)
                {
                    GenerationButtonWorkBase(0, 21, ConsoleColor.Gray);
                    GenerationButtonWorkBase(21, 22, ConsoleColor.Green);
                    //GenerationButtonWorkBase(6, 22, ConsoleColor.Gray);
                }
            }


        }


    }
}
