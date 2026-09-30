matriz_3d = [
    [
        [1, 2],
        [3, 4]
    ],
    [
        [5, 6],
        [7, 8]
    ]
]

for i in range(len(matriz_3d)):
    for j in range(len(matriz_3d[i])):
        for k in range(len(matriz_3d[i][j])):
            print(f"[{i}][{j}][{k}] = {matriz_3d[i][j][k]}")