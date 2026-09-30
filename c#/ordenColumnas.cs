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

        for (int j = 0; j < cols; j++)
        {
            for (int i = 0; i < filas - 1; i++)
            {
                for (int k = 0; k < filas - i - 1; k++)
                {
                    if (matriz[k, j] > matriz[k + 1, j])
                    {
                        int temp = matriz[k, j];
                        matriz[k, j] = matriz[k + 1, j];
                        matriz[k + 1, j] = temp;
                    }
                }
            }
        }
    }
}