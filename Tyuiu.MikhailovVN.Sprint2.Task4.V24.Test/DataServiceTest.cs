
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
            double x = 5;
            double y = 5;
            double res = service.Calculate(x, y);
            double wait = 0.942;
            Assert.AreEqual(wait, res);
        }

        public void TestMethod2()
        {
            DataService service = new DataService();
            double x = 5;
            double y = 5;
            double res = service.Calculate(x, y);
            double wait = 0.942;
            Assert.AreEqual(wait, res);
        }
    }
}
