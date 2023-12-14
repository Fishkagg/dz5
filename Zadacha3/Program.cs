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

int Min(int[,] matrix)
{
    int minRowIndex = 0;
    int minsum = int.MaxValue;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (sum < minsum){
            minsum = sum;
            minRowIndex = i;
        }
    }
    return minRowIndex;
}

int row = Read("Введите количество строк 2-х мерного массива: ");
int column = Read("Введите количество столбцов 2-х мерного массива: ");
int[,] myMatrix = Generate(row, column, -9, 10);
Print(myMatrix);

int minRowIndex = Min(myMatrix);
Console.WriteLine($"Идекс строки массива с наиеньшей суммой элеметов = {minRowIndex}");
