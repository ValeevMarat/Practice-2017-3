using System;

// Задание №3 практики 2017г. 
// Задание 60в, стр. 22: Определить u, в зависимости от принадлежности точки к области
// Ссылка на "Задачи по программированию": http://aesa.kz:8081/computer-science/abramov.pdf

namespace Practice_2017_3
{
    class Program
    {
        public static double ReadDouble(string error = "Ошибка, введите вещественное значение (целая от вещественной части отделяется запятой)")
        {
            bool ok; // маркер выхода из цикла
            double input = 0; // переменная для хранения полученного числа

            do
            {
                try
                {
                    ok = true;
                    input = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine(error);
                    ok = false;
                }
                catch (OverflowException)
                {
                    Console.Clear();
                    Console.WriteLine("Ошибка, число слишком большое/маленькое");
                    ok = false;
                }
            } while (!ok);

            return input;
        } // Считывание вещественных чисел с проверкой, error - стандартное сообщение для ошибки

        static void Main(string[] args)
        {
            Console.Write("Введите координату х: ");
            double x = ReadDouble();                                                // Последовательное чтение х и у

            Console.Write("Введите координату y: ");
            double y = ReadDouble();

            if (Math.Pow(x, 2) + Math.Pow(y - 1, 2) <= 1 & y <= 1 - Math.Pow(x, 2)) // Если точка принадлежит заданной области (см. задание в учебнике), то u=x-y, иначе u=xy+7
                Console.WriteLine("u = "+(x-y));
            else Console.WriteLine("u = " + (x*y+7));

            Console.ReadLine();
        }                                                                                                          // Чтение точки и вывод u
    }
}
