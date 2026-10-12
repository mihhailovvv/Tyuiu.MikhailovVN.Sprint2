
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
            Assert.AreEqual("зима", service.FindMonthSeason(1));
            Assert.AreEqual("зима", service.FindMonthSeason(2));
            Assert.AreEqual("весна", service.FindMonthSeason(3));
            Assert.AreEqual("весна", service.FindMonthSeason(4));
            Assert.AreEqual("весна", service.FindMonthSeason(5));
            Assert.AreEqual("лето", service.FindMonthSeason(6));
            Assert.AreEqual("лето", service.FindMonthSeason(7));
            Assert.AreEqual("лето", service.FindMonthSeason(8));
            Assert.AreEqual("осень", service.FindMonthSeason(9));
            Assert.AreEqual("осень", service.FindMonthSeason(10));
            Assert.AreEqual("осень", service.FindMonthSeason(11));
            Assert.AreEqual("зима", service.FindMonthSeason(12));
            

            Assert.ThrowsException<ArgumentException>(() => service.FindMonthSeason(13));
            Assert.ThrowsException<ArgumentException>(() => service.FindMonthSeason(-1));
        }


        
    }
}
