
using Tyuiu.MikhailovVN.Sprint2.Task3.V9.Lib;
namespace Tyuiu.MikhailovVN.Sprint2.Task3.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Test_1_Task3()
        {
            DataService ds = new DataService();
            double x = 5;
            double res = ds.Calculate(x);
            double wait = -500000;
            Assert.AreEqual(res, wait);

        }

        [TestMethod]
        public void Test_2_Task3()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 1;
            Assert.AreEqual(res, wait);
        }

        [TestMethod]
        public void Test_3_Task3()
        {
            DataService ds = new DataService();
            double x = -2;
            double res = ds.Calculate(x);
            double wait = 0.25;
            Assert.AreEqual(res, wait);
        }

        [TestMethod]
        public void Test_4_Task3()
        {
            DataService ds = new DataService();
            double x = -14;
            double res = ds.Calculate(x);
            double wait = -154.071;
            Assert.AreEqual(res, wait);
        }
    }
}
