using Tyuiu.PolyakovaAS.Sprint6.Task1.V23.Lib;

namespace Tyuiu.PolyakovaAS.Sprint6.Task1.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(new double[] { -0.65, 5.57, 14.02, 12.37, -3.3 }, ds.GetMassFunction(1, 5));
        }
    }
}

