using Tyuiu.MolokanovNK.Sprint4.Task1.V26.Lib;

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

int len;
Console.WriteLine("Введите количество элементов массива");
len = Convert.ToInt32(Console.ReadLine());
int[] numsArry= new int[len];
for (int i = 0; i < len; i++)
{
    Console.WriteLine("Введите значение " + i + "элемент массива");
    numsArry[i] = Convert.ToInt32(Console.ReadLine());
}  
Console.WriteLine();
Console.WriteLine("Массив: ");
for (int i = 0; i < len; i++)
{
    Console.Write(numsArry[i] + "\t");
}
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("***********************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                  *");
Console.WriteLine("***********************************************************************************************");

int res = ds.Calculate(numsArry);

Console.WriteLine(res);
Console.ReadLine();
