
using Tyuiu.MikhailovVN.Sprint2.Task7.V7.Lib;
namespace Tyuiu.MikhailovVN.Sprint2.Task7.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x1 = 0.0;
            double y1 = 1.0;

            bool res = ds.CheckDotInShadedArea(x1, y1);
            bool wait = true;
            Assert.AreEqual(wait, res);

        }

        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();

            double x2 = 0.0;
            double y2 = 2.0;

            bool res = ds.CheckDotInShadedArea(x2, y2);
            bool wait = true;
            Assert.AreEqual(wait, res);

        }

        [TestMethod]
        public void TestMethod3()
        {
            DataService ds = new DataService();

            double x3 = 0.2;
            double y3 = 0.8;

            bool res = ds.CheckDotInShadedArea(x3, y3);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestMethod4()
        {
            DataService ds = new DataService();

            double x4 = -0.2;
            double y4 = 0.8;

            bool res = ds.CheckDotInShadedArea(x4, y4);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
