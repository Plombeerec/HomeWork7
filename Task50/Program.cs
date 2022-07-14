// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.


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

void CheckPosition(int[,] array, int PosInRows, int PosInColumns)
{
    bool c = false;
    for(int i = 0; i < array.GetLength(0); i++ )
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            
            if(PosInRows -1 == i && PosInColumns -1 == j)
            {
                c = true;             
            }         
        }
    }
    if (c)
    {
        Console.WriteLine($"Искомое число найдено {array[PosInRows - 1,PosInColumns - 1]}");
    }
    else
    {
        Console.WriteLine("В массиве отсутствует параметр с заданным значением");
    }
}

Console.WriteLine("input number of rows");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input number of columns");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер элемента в строке");
int fx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер элемента в строке");
int fy = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandomArray(m , n, 1, 9);
ShowArray(myArray);
CheckPosition(myArray,fx , fy);