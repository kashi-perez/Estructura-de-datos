#include <iostream>

int main() {
    int matriz3D[2][2][2] = {
        {
            {1, 2},
            {3, 4}
        },
        {
            {5, 6},
            {7, 8}
        }
    };

    int capas = 2;
    int filas = 2;
    int cols = 2;

    for (int i = 0; i < capas; i++) {
        for (int j = 0; j < filas; j++) {
            for (int k = 0; k < cols; k++) {
                std::cout << "[" << i << "][" << j << "][" << k << "] = " << matriz3D[i][j][k] << std::endl;
            }
        }
    }

    return 0;
}