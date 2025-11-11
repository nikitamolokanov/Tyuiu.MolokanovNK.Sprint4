using Tyuiu.MolokanovNK.Sprint4.Task7.V3.Lib;

namespace Tyuiu.MolokanovNK.Sprint4.Task7.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int rows = 4;
            int cols = 2;
            int[,] mtrx = new int[rows, cols];
            string str = "27182818";
            DataService ds = new DataService();
            int res = ds.Calculate(rows,cols, str);
            int wait = 3;
            Assert.AreEqual(wait, res); 
        }
    }
}
