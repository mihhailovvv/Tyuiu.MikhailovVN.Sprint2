
using Tyuiu.MikhailovVN.Sprint2.Task5.V2.Lib;
namespace Tyuiu.MikhailovVN.Sprint2.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service = new DataService();
            Assert.AreEqual("Зима", service.FindMonthSeason(1));
            Assert.AreEqual("Зима", service.FindMonthSeason(2));
            Assert.AreEqual("Весна", service.FindMonthSeason(3));
            Assert.AreEqual("Весна", service.FindMonthSeason(4));
            Assert.AreEqual("Весна", service.FindMonthSeason(5));
            Assert.AreEqual("Лето", service.FindMonthSeason(6));
            Assert.AreEqual("Лето", service.FindMonthSeason(7));
            Assert.AreEqual("Лето", service.FindMonthSeason(8));
            Assert.AreEqual("Осень", service.FindMonthSeason(9));
            Assert.AreEqual("Осень", service.FindMonthSeason(10));
            Assert.AreEqual("Осень", service.FindMonthSeason(11));
            Assert.AreEqual("Зима", service.FindMonthSeason(12));
            

            Assert.ThrowsException<ArgumentException>(() => service.FindMonthSeason(13));
            Assert.ThrowsException<ArgumentException>(() => service.FindMonthSeason(-1));
        }


        
    }
}
