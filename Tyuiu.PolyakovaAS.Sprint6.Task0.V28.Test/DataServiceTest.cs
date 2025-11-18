using Tyuiu.PolyakovaAS.Sprint6.Task0.V28.Lib;

namespace Tyuiu.PolyakovaAS.Sprint6.Task0.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 169.89;
            Assert.AreEqual(res, wait);
        }
    }
}


