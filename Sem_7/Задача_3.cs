Console.Clear();
Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine()!);

int[,] array = new int[row, column];

void CreateArrayInt(int[,] array)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            int alignNumber = array[i, j];
            Console.Write(alignNumber + " \t ");
        }
        Console.WriteLine();
    }
}
CreateArrayInt(array);
WriteArray(array);
Console.WriteLine();

Console.Write($"\nCреднее арифметическое:\n");
for (int i = 0; i < column; i++)
{
    double arithmeticMean = 0;
    for (int j = 0; j < row; j++)
    {
        arithmeticMean += array[j, i];
    }
    arithmeticMean = arithmeticMean / row;
    Console.WriteLine($"столбца {i + 1} = {Math.Round(arithmeticMean, 1)}");
}