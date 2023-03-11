// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



int GetValueFromUser(string message)
{
    Console.WriteLine(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

void FillMatrix(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            matrix[rows, columns] = new Random().Next(1,100);
        }
    }
}

void OrderMaxToMin(int [,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++) 
    {   
        for (int i = 0; i < matrix.GetLength(1); i++) 
        {
            for (int columns = 0; columns < matrix.GetLength(1) - 1; columns++)
            {
                if(matrix[rows, columns] < matrix[rows, columns + 1])
                {
                    int temp = matrix[rows, columns];
                    matrix[rows, columns] = matrix[rows, columns + 1];
                    matrix[rows, columns + 1] = temp;
                } 
            }
        }
    }
}

void PrintMatrix(int[,] matrix)
{
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        Console.WriteLine("\n");
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            Console.Write($"{matrix[rows, columns]} | ");
        }
    }
}

int[,] matrix = new int[GetValueFromUser("Number of rows > "),
                        GetValueFromUser("Number of columns > ")];

FillMatrix(matrix);
OrderMaxToMin(matrix);
PrintMatrix(matrix);