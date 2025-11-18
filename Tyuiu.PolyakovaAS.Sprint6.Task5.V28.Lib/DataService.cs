using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PolyakovaAS.Sprint6.Task5.V28.Lib
{
    public class DataService : ISprint6Task5V28
    {
        public double[] LoadFromDataFile(string path)
        {
            
            string[] lines = File.ReadAllLines(path);

            
            double[] numsArray = lines
                .Select(line => Convert.ToDouble(line))
                .Select(val => Math.Round(val, 3)) 
                .Where(val => val < 10) 
                .ToArray();

            
            foreach (var num in numsArray)
            {
                Console.WriteLine(num);
            }

            return numsArray;
        }
    }
}
