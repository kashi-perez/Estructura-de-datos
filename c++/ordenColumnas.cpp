#include <iostream>
#include <vector>
#include <algorithm>

int main() {
    int matriz[3][3] = {
        {5, 2, 9},
        {1, 7, 4},
        {3, 8, 6}
    };

    int filas = 3;
    int cols = 3;

    for (int j = 0; j < cols; j++) {
        std::vector<int> columna(filas);
        for (int i = 0; i < filas; i++) {
            columna[i] = matriz[i][j];
        }
        std::sort(columna.begin(), columna.end());
        for (int i = 0; i < filas; i++) {
            matriz[i][j] = columna[i];
        }
    }

    return 0;
}