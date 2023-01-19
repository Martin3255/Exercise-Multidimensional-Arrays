using System.Collections.Immutable;
using System.Reflection;
int[] dimentions = Console.ReadLine()
                          .Split(' ')
                          .Select(int.Parse)
                          .ToArray();
int rows = dimentions[0];
int cols = dimentions[1];
string[,] matrix = new string[rows, cols];

for (int row = 0; row < rows; row++)
{
    string[] strings = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = strings[col];
    }
}
while (true)
{
    string command = Console.ReadLine();
    if (command == "END")
    {
        break;
    }
    string[] tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
}   