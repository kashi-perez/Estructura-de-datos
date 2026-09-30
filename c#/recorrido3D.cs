using System;

class Program
{
    static void Main()
    {
        int[,,] matriz3D = {
            {
                { 1, 2 },
                { 3, 4 }
            },
            {
                { 5, 6 },
                { 7, 8 }
            }
        };

        for (int i = 0; i < matriz3D.GetLength(0); i++)
        {
            for (int j = 0; j < matriz3D.GetLength(1); j++)
            {
                for (int k = 0; k < matriz3D.GetLength(2); k++)
                {
                    Console.WriteLine($"[{i}][{j}][{k}] = {matriz3D[i, j, k]}");
                }
            }
        }
    }
}