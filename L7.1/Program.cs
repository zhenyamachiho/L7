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

double[,] InitMatrix(double m, double n)
{
    double[,] matrix = new double[(int)m, (int)n];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10) + rnd.NextDouble();
        }
    }

    return matrix;
}

void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(matrix[i, j], 2)} ");
        }

        Console.WriteLine();
    }
}

int m = GetNumber("Введите кол-во строк");
int n = GetNumber("Введите кол-во столбцов");

double[,] matrix = InitMatrix(m, n);

PrintArray(matrix);
