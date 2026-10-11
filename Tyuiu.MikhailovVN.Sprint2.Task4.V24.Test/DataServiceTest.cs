
using Tyuiu.MikhailovVN.Sprint2.Task4.V24.Lib;
namespace Tyuiu.MikhailovVN.Sprint2.Task4.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service = new DataService();
            double x = 2;
            double y = -22;
            double res = service.Calculate(x, y);
            double wait = 760.5;
            Assert.AreEqual(res, wait);
        }

        public void TestMethod2()
        {
            DataService service = new DataService();
            double x = 0;
            double y = 0;
            double res = service.Calculate(x, y);
            double wait = 0.833;
            Assert.AreEqual(res, wait);
        }
    }
}
