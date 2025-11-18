using Tyuiu.PolyakovaAS.Sprint6.Task4.V19.Lib;

namespace Tyuiu.PolyakovaAS.Sprint6.Task4.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            int startValue = 0;
            int endValue = 0;
            int len = startValue - endValue + 1;
            double[] array = new double[len];
            array = ds.GetMassFunction(startValue, endValue);
            double[] WaitArray = new double[len];
            WaitArray[0] = 0.75;
            Assert.AreEqual(WaitArray[0], array[0]);
        }
    }
}
