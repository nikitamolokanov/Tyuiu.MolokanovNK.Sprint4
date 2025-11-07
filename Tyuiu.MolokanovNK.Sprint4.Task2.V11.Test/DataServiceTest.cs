using Tyuiu.MolokanovNK.Sprint4.Task2.V11.Lib;

namespace Tyuiu.MolokanovNK.Sprint4.Task2.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
           DataService ds = new DataService();

            int[] numsArray = { 3, 6, 7, 7, 6, 3, 4, 5, 9, 8, 3, 4, 5, 6, 6, 6 };
            int res = ds.Calculate(numsArray);
            int wait = 1;
            Assert.AreEqual(wait, res);
        }
    }
}
