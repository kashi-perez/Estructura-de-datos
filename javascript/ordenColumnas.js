const matriz = [
    [5, 2, 9],
    [1, 7, 4],
    [3, 8, 6]
];

const filas = matriz.length;
const cols = matriz[0].length;

for (let j = 0; j < cols; j++) {
    const columna = [];
    for (let i = 0; i < filas; i++) {
        columna.push(matriz[i][j]);
    }
    columna.sort((a, b) => a - b);
    for (let i = 0; i < filas; i++) {
        matriz[i][j] = columna[i];
    }
}

console.log(matriz);