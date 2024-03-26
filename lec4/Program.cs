// Task 1

int[,] CreateMatrix(int rowCount,int columnCount) {
    int [,] matrix=new int[rowCount,columnCount];
    Random rnd=new Random();
    for (int i=0;i<matrix.GetLength(0);i++) {
        for (int j=0;j<matrix.GetLength(1);j++) {
            matrix[i,j]=rnd.Next(1,11);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix) {
    for (int i=0;i<matrix.GetLength(0);i++) {
        for (int j=0;j<matrix.GetLength(1);j++) {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

int [,] matrix=CreateMatrix(3,10);
PrintMatrix(matrix);

// Виды инициализации многомерных массивов
int[,] mtr1=new int[2,4] {{1,1,1,1},{2,2,2,2}};
int[,] mtr2=new int[,] {{1,1,1,1},{2,2,2,2}};
int[,] mtr3={{1,1,1,1},{2,2,2,2}};

// Task 2 26:00
