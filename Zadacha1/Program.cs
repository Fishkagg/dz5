int Read(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] Generate(int row, int column, int leftRange, int rightRange)
{   
    int[,] matrix = new int[row, column];
    Random rand = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}


void Print(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");  
        }
        Console.WriteLine();
    }
}

void Find(int[,] matrix, int x, int y)
{
    if (x > matrix.GetLength(0) || y > matrix.GetLength(1)){
        Console.WriteLine($"Элемента массива с индексом [{x}, {y}] не существует");

    }
    else Console.WriteLine($"Искомый элемент массива = {matrix[x, y]}");
}


int row = Read("Введите количество строк 2-х мерного массива: ");
int column = Read("Введите количество столбцов 2-х мерного массива: ");
int[,] myMatrix = Generate(row, column, -9, 10);
Print(myMatrix);

int x = Read("Веедите индекс искомой строки: ");
int y = Read("Ведите индекс искомого столбца: ");
Find(myMatrix, x, y);
