
using Tyuiu.MikhailovVN.Sprint2.Task2.V9.Lib;
namespace Tyuiu.MikhailovVN.Sprint2.Task2.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int x = 5;
            int y = 3;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(res, wait);

        }
    }
}
