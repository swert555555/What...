using System;

namespace IgriSamostaiat
{
    internal class Program
    {
        static void Main()
        {
            string vivod = "Выбери игру, в которую хочешь сыграть:\r\n" +
                "1 - Угадай число\r\n2 - Таблица умножения\r\n3 - Делители числа\r\n4 - Закончить";
            Console.WriteLine(vivod);
            int prog = Convert.ToInt16(Console.ReadLine());
            for (; prog != 4; prog = Convert.ToInt16(Console.ReadLine()))
                if (prog == 1)
                {
                    First();
                    Console.WriteLine(vivod);
                }
                else if (prog == 2)
                {
                    Second();
                    Console.WriteLine(vivod);
                }
                else if (prog == 3)
                {
                    Third();
                    Console.WriteLine(vivod);
                }
                else
                {
                    break;
                }


        }
        static void First()
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 100);
            Console.WriteLine("Попробуй отгадать то, что загадал рандом (от 0 до 100): ");
            int chislo = Convert.ToInt32(Console.ReadLine());
            int i;
            for (i = 0; chislo != value; chislo = Convert.ToInt32(Console.ReadLine()))
            {
                 Console.WriteLine("Не попал! Попробуй еще раз: ");
                 if (chislo < value)
                      Console.WriteLine("(бери больше)");
                 else
                      Console.WriteLine("(бери меньше)");
                i++;
            }
            Console.WriteLine("Поздравляю! Игра окончена. Вы отгадали за "+ i +" попыток");
        }
        static void Second() //табл умножения
        {
            int[,] ints = new int[9, 10];
            for (int i = 0; i < ints.GetLength(0); i++)
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    ints[i,j] = i * j;
                }

            for (int i = 1; i < ints.GetLength(0); i++)
                for (int j = 1; j < ints.GetLength(1); j++)
                {
                    Console.Write($"{j}*{i} = {ints[i, j]}\t");
                }
        }
        static void Third() //делители числа
        {
            Console.WriteLine("Введите ваше число: ");
            int intes = Convert.ToInt32(Console.ReadLine());
            int[] delit = new int[intes];
            for (int i = 1, j = 0; i <= intes; i++)
                if (intes % i == 0)
                { 
                    delit[j] = i;
                    j++;
                    Console.WriteLine(i + "\t");
                }
            
        }
    }
}