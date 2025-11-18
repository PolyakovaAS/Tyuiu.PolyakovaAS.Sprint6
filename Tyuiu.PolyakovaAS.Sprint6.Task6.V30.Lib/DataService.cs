using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PolyakovaAS.Sprint6.Task6.V30.Lib
{
    public class DataService : ISprint6Task6V30
    {
        public string CollectTextFromFile(string path)
        {
            string result = "";

            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (!string.IsNullOrEmpty(line))
                        {
                            string[] words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                            
                            if (words.Length >= 4)
                            {
                                
                                result += words[3] + " ";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Ошибка при чтении файла: {ex.Message}";
            }

            return result.Trim();
        }
    }
}
