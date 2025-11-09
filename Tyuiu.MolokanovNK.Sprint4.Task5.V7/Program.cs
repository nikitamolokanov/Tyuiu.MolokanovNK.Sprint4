using Tyuiu.MolokanovNK.Sprint4.Task5.V7.Lib;

Random rnd = new Random();
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

Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, cols];
Console.WriteLine("***********************************************************************************************");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        matrix[i, j] = rnd.Next(-7, 7);
}   }
Console.WriteLine("\nМассив: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write($"{matrix[i, j]}\t ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("***********************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                  *");
Console.WriteLine("***********************************************************************************************");

int res = ds.Calculate(matrix);



Console.WriteLine("Количество заменных элементов:" + res);
Console.ReadKey();