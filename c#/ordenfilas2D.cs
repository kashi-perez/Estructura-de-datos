using System;

class Program
{
    static void Main()
    {
        int[,] matriz = {
            { 5, 2, 9 },
            { 1, 7, 4 },
            { 3, 8, 6 }
        };

        int filas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < cols - 1; j++)
            {
                for (int k = 0; k < cols - j - 1; k++)
                {
                    if (matriz[i, k] > matriz[i, k + 1])
                    {
                        int temp = matriz[i, k];
                        matriz[i, k] = matriz[i, k + 1];
                        matriz[i, k + 1] = temp;
                    }
                }
            }
        }
    }
}