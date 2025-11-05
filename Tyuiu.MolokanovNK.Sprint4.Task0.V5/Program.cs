using Tyuiu.MolokanovNK.Sprint4.Task0.V5.Lib;


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

int[] numsArray = {  8, 9, 4, 1, 2, 3, 4, 5, 6, 7  };
Console.WriteLine("Исходный Массив");
for (int i = 0; i < numsArray.Length; i++)
Console.WriteLine(numsArray[i]);


Console.WriteLine("***********************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                  *");
Console.WriteLine("***********************************************************************************************");
Console.WriteLine("Сумма четких элементов:");

int sum = ds.GetSumEvenArrEl(numsArray);

for(int i = 0; i < numsArray.Length; i++)
Console.Write(numsArray[i] + "\t");

Console.WriteLine("Сумма четких элементов:"+ sum);
Console.WriteLine();
Console.ReadLine();



