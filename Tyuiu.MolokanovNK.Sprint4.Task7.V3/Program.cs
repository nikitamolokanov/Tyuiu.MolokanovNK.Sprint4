using Tyuiu.MolokanovNK.Sprint4.Task7.V3.Lib;
int n = 4;
int m = 2;
int[,] mtrx = new int[n, m];

string str = "27182818";


DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнил : Молоканов Н. К. | ИБКСб-25-1";
//Длина строки 75 символов
Console.WriteLine("***********************************************************************************************");
Console.WriteLine("* Спринт #4                                                                                   *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                                            *");
Console.WriteLine("* Задание #1                                                                                  *");
Console.WriteLine("* Вариант #26                                                                                 *");
Console.WriteLine("* Выполнил: Молоканов Никита Константинович | ИБКСб-25-1                                      *");
Console.WriteLine("***********************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                                    *");
Console.WriteLine("* Написать программу используя цикл for, которая вычисляет произведение ряда по формуле       *");
Console.WriteLine("*                                                                                             *");
Console.WriteLine("***********************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                            *");
Console.WriteLine("***********************************************************************************************");

int index = 0;
Console.WriteLine("\nМассив: ");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write($"{str[index]} \t");
        index++;
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("***********************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                  *");
Console.WriteLine("***********************************************************************************************");

int res = ds.Calculate(n,m,str);

Console.WriteLine("Количество нечетных элементов = " + res);
Console.ReadKey();