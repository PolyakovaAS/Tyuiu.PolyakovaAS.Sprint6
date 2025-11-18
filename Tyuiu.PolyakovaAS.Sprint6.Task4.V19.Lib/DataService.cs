using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PolyakovaAS.Sprint6.Task4.V19.Lib
{
    public class DataService : ISprint6Task4V19
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] array = new double[len];
            double y = 0;
            int c = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(((5 * x + 2.5) / (Math.Sin(x) - 2)) + 2, 2);
                if (double.IsInfinity(y))
                {
                    y = 0;
                }
                array[c] = y;
                c++;
            }
            return array;
        }
    }
}
