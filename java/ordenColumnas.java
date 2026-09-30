import java.util.Arrays;

public class ordenColumnas {
    public static void main(String[] args) {
        int[][] matriz = {
            {5, 2, 9},
            {1, 7, 4},
            {3, 8, 6}
        };

        int filas = matriz.length;
        int cols = matriz[0].length;

        for (int j = 0; j < cols; j++) {
            int[] columna = new int[filas];
            for (int i = 0; i < filas; i++) {
                columna[i] = matriz[i][j];
            }
            Arrays.sort(columna);
            for (int i = 0; i < filas; i++) {
                matriz[i][j] = columna[i];
            }
        }
    }
}
