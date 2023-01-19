using System.Data;

int size = int.Parse(Console.ReadLine());
int[,] matrix = new int[size, size];

for (int row = 0; row < size; row++)
{
    int[] numbers = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    for (int col = 0; col < size; col++)
    {
        matrix[row, col] = numbers[col];
    }
}

decimal leftToRightSum = 0;
decimal rightToLeftSum = 0;

for (int i = 0, j = size - 1; i < size; i++, j--)
{
    leftToRightSum += matrix[i, i];
    rightToLeftSum += matrix[j, i];
}
Console.WriteLine(Math.Abs(leftToRightSum-rightToLeftSum));