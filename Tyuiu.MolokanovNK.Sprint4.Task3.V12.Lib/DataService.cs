using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MolokanovNK.Sprint4.Task3.V12.Lib
{
    public class DataService : ISprint4Task3V12
    {
        public int Calculate(int[,] array)
        {
            int min = int.MaxValue;

            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i, 2] < min)
                {
                    min = array[i, 2];
                }
            }

            return min;
        }
    }
}
