
import java.util.Arrays;

public class orden2D {
    public static void main(String[] args) {
        int[][] matriz = {
            {5, 2, 9},
            {1, 7, 4},
            {3, 8, 6}
        };

        for (int i = 0; i < matriz.length; i++) {
            Arrays.sort(matriz[i]);
        }
    }
}