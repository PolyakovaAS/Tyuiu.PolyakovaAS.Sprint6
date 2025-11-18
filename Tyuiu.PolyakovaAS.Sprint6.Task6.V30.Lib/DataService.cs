using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
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
                            foreach (string word in words)
                            {
                                // Пример: слова длиной более 3 символов
                                if (word.Length > 3)
                                {
                                    result += word + " ";
                                }
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