using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PolyakovaAS.Sprint6.Task7.V25.Lib
{
    public class DataService : ISprint6Task7V25
    {
        public int[,] GetMatrix(string path)
        {
            // Читаем все строки из файла
            string[] lines = File.ReadAllLines(path);

            // Определяем размеры матрицы
            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;

            int[,] matrix = new int[rows, cols];

            // Заполняем матрицу данными из файла
            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            // Преобразуем матрицу: заменяем элементы в 7-м столбце, кратные 5, на 2
            for (int i = 0; i < rows; i++)
            {
                // 7-й столбец имеет индекс 6 (нумерация с 0)
                if (matrix[i, 6] % 5 == 0) // Проверяем, кратно ли число 5
                {
                    matrix[i, 6] = 2;
                }
            }

            return matrix;
        }
    }
}

