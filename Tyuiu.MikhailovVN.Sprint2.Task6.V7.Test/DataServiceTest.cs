
using Tyuiu.MikhailovVN.Sprint2.Task6.V7.Lib;
namespace Tyuiu.MikhailovVN.Sprint2.Task6.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            Assert.AreEqual("январь", ds.FindMonthName(1990, 0));   
            Assert.AreEqual("февраль", ds.FindMonthName(1990, 1));  
            Assert.AreEqual("декабрь", ds.FindMonthName(1990, 11)); 
            Assert.AreEqual("январь", ds.FindMonthName(1990, 12));  
        }
    }
}
