int[] dimentions = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .ToArray();
int rows = dimentions[0];
int cols = dimentions[1];
char[,] matrix = new char[rows, cols];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    char[] chars = Console.ReadLine()
        .Split(' ')
        .Select(n => char.Parse(n))
        .ToArray();
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = chars[col];
    }

}

int count = 0;

for (int row = 0; row < matrix.GetLength(0) - 1; row++)
{
    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
    {
        if (matrix[row, col] == matrix[row, col + 1] &&
            matrix[row, col] == matrix[row + 1, col + 1] &&
            matrix[row, col] == matrix[row + 1, col])
        {
            count++;
        }
    }
}

Console.WriteLine(count);