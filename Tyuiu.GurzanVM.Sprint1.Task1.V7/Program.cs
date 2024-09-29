using Tyuiu.GurzanVM.Sprint1.Task1.V7.Lib;
//ЗАДАНИЕ
//Написать программу, которая запрашивает у пользователя исходные данные,
//вычисляет результат по формуле x / ( y - 1 ) и печатает его на экране.

namespace Tyuiu.GurzanVM.Sprint1.Task1.V7
{

    class program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Гурзан.В.М | СМАРТБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Организация ввода и ввывода в консольное приложение               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Гурзан Владислав Михайлович |  СМАРТБ-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователяисходные данные,  *");
            Console.WriteLine("* вычисляет по формуле (5 * x) / (y + x) и печатает на экране.            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            double x, y;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));

            Console.ReadLine();

        }



    }



}
