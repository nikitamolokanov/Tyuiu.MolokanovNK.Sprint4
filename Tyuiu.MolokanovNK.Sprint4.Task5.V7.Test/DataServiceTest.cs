using Tyuiu.MolokanovNK.Sprint4.Task5.V7.Lib;

namespace Tyuiu.MolokanovNK.Sprint4.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] numsMatrix =
                                     { { 2, -2, 5, -5, 9 },
                                       { -7, 3, 8, 8, -9 },
                                       { 6, 7, 9, 3, 5 },
                                       { 7, -5, 7, 7, 8 },
                                       { 2, 2, -4, 7, 9 } };
                                                           
           
            int res = ds.Calculate(numsMatrix);
            int wait = 6;
            Assert.AreEqual(wait, res);
        }
    }
}
