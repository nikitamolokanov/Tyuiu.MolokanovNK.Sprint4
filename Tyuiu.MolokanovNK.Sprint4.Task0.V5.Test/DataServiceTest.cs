using Tyuiu.MolokanovNK.Sprint4.Task0.V5.Lib;

namespace Tyuiu.MolokanovNK.Sprint4.Task0.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numsArray = { 8, 9, 4, 1, 2, 3, 4, 5, 6, 7 };
            int res = ds.GetSumEvenArrEl(numsArray);  
            int numsWaitArray = 8 + 4 + 2 + 4 + 6;     

            Assert.AreEqual(numsWaitArray, res);       
        }
    }
}
