using Tyuiu.MolokanovNK.Sprint4.Task3.V12.Lib;

int[,] ary =  new int[5,5]  { { 9, 7, 4, 9, 7, },

                              { 5, 2, 5, 7, 6, },

                              { 8, 3, 3, 5, 7, },

                              { 8, 4, 2, 4, 5, },

                             { 8, 8, 9, 5, 6, } };
int rows = ary.GetUpperBound(0) + 1;
int columns = ary.Length / rows;


DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнил : Молоканов Н. К. | ИБКСб-25-1";
//Длина строки 75 символов
Console.WriteLine("***********************************************************************************************");
Console.WriteLine("* Спринт #3                                                                                   *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                                            *");
Console.WriteLine("* Задание #0                                                                                  *");
Console.WriteLine("* Вариант #6                                                                                  *");
Console.WriteLine("* Выполнил: Молоканов Никита Константинович | ИБКСб-25-1                                      *");
Console.WriteLine("***********************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                                    *");
Console.WriteLine("* Написать программу используя цикл for, которая вычисляет произведение ряда по формуле       *");
Console.WriteLine("*                                                                                             *");
Console.WriteLine("***********************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                            *");
Console.WriteLine("***********************************************************************************************");
Console.WriteLine("Массив:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{ary[i, j]}\t");
    }
    Console.WriteLine();
}


Console.WriteLine("***********************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                  *");
Console.WriteLine("***********************************************************************************************");


int res = ds.Calculate(ary);

Console.WriteLine("Сумма четких элементов:" + res);

Console.ReadLine();