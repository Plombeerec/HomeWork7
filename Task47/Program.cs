// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

double[,] CreateRandomDoubleArray(int rows, int columns, int min, int max)
{
    double[,] newArray = new double[rows, columns];

    for(int i = 0; i <rows; i++)
    {
        for(int j = 0; j <columns; j++)
        {
            newArray[i,j] = new Random().Next(min, max+1) + (new Random().NextDouble());;
        }
    }
    return newArray;
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++ )
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(Math.Round(array[i,j], 2) + " ");
        }
    Console.WriteLine();
    }
}
Console.WriteLine("input number of rows");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input number of columns");
int n = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandomDoubleArray(m , n, 1, 9);
Show2dArray(myArray);