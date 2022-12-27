int GetNumber(string message)
{
    int result;

    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число.");
        }
    }

    return result;
}

int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }

    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }

        Console.WriteLine();
    }
}

void PrintNumber(int[,] matrix)
{
    int a = GetNumber("Введите позицию строки");
    int b = GetNumber("Введите позицию столбца");
    if (matrix.GetLength(0) < a || matrix.GetLength(1) < b)
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
    else
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i == a && j == b)
                {
                    Console.WriteLine($"{matrix[i, j]}");
                }
            }
        }
    }
}
int m = GetNumber("Введите кол-во строк");
int n = GetNumber("Введите кол-во столбцов");


int[,] matrix = InitMatrix(m, n);

PrintArray(matrix);
PrintNumber(matrix);
