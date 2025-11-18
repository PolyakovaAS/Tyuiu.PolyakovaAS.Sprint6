using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PolyakovaAS.Sprint6.Task1.V23.Lib
{
    public class DataService : ISprint6Task1V23
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            List<double> ans = new List<double>();
            for (double i = startValue; i <= stopValue; i++)
            {
                ans.Add(Math.Round(Math.Sin(i) + ((2d * i) / 3d) - Math.Cos(i) * 4d * i, 2));
            }
            double[] ans_ = ans.ToArray();
            return ans_;
        }
    }
}
