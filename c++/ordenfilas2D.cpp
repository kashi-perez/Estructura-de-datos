#include <iostream>
#include <algorithm>

int main() {
    int matriz[3][3] = {
        {5, 2, 9},
        {1, 7, 4},
        {3, 8, 6}
    };

    int filas = 3;
    int cols = 3;

    for (int i = 0; i < filas; i++) {
        std::sort(matriz[i], matriz[i] + cols);
    }

    return 0;
}