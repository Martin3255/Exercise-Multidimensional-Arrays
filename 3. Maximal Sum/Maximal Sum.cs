using System.Security.Cryptography.X509Certificates;

int[] dimentions = Console.ReadLine()
                          .Split(' ')
                          .Select(int.Parse)
                          .ToArray();
int rows = dimentions[0];
int cols = dimentions[1];
int[,] matrix = new int[rows, cols];    

for (int row = 0; row < rows; row++)
{
    int[] numbers = Console.ReadLine()
                           .Split(' ')
                           .Select(int.Parse)
                           .ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = numbers[col];
    }
}

int maxSum = int.MinValue;
int maxSumRow = 0;
int maxSumCol = 0;

for (int row = 0; row < rows - 2; row++)
{
    for (int col = 0; col < cols - 2; col++)
    {
        int currentSum =
            matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
            matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
            matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

        if (currentSum > maxSum)
        {
            maxSum = currentSum;
            maxSumRow = row;
            maxSumCol = col;
        }
    }
}

Console.WriteLine($"Sum = {maxSum}");

for (int row = maxSumRow; row < maxSumRow + 3; row++)
{
    for (int col = maxSumCol; col < maxSumCol + 3; col++)
    {
        Console.Write($"{matrix[row, col]} ");
    }

    Console.WriteLine();
}