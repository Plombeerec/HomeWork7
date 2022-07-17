// Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.


int[,] CreateRandomArray(int rows, int columns, int min, int max)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i <rows; i++)
    {
        for(int j = 0; j <columns; j++)
        {
            newArray[i,j] = new Random().Next(min, max+1);
        }
    }
    return newArray;
}

void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++ )
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
    Console.WriteLine();
    }
}

void Average(int[,] array)
{
    int count = 0;
    double result = 0;
    for(int i = 0; i < array.GetLength(0); i++ )
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if( j == 0)
            {
                count = 0;
            }
            count +=array[j,i];
            result = (double)count / (array.GetLength(1)) ;
        }
        Console.WriteLine("Count is "+  count);
        Console.WriteLine("Result is " + result);
    }
    return ;
}


Console.WriteLine("input number of rows");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input number of columns");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandomArray(m , n, 1, 9);
ShowArray(myArray);
Average(myArray);