using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PolyakovaAS.Sprint6.Task6.V30.Lib
{
    public class DataService : ISprint6Task6V30
    {
        public string CollectTextFromFile(string str, string path) {


            string strLine = "";
            string line;
            using (StreamReader reader = new StreamReader(path))
            {

                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');
                    foreach (string word in words)
                    {
                        if (word.Contains(str)) strLine += word + " ";
                    }
                }
            }
            return strLine.Trim();
        }
        
        

        

        public string CollectTextFromFile(string path)
        {
            throw new NotImplementedException();
        }
    }
}
