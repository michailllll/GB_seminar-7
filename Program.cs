// программа выводит двумерный массив
// void Printarray(double[,]matr)
// {
//     for(int i = 0; i < matr.GetLength(0); i++)
//     {
//         for(int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i,j]} ");
//         }
//         Console.WriteLine();
//     }

// }


// void Fillarray(double[,]matr)
// {
//     for(int i = 0; i < matr.GetLength(0); i++)
//     {
//         for(int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] = new Random().Next(-10,10);
//         }
//     }

// }

// double[,] matrix = new double[3,4];

// Fillarray(matrix);
// Printarray(matrix);


// программа, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Console.WriteLine("введите количество строк матрицы ");
// int quantityString = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("введите количество столбцов матрицы ");
// int quantityColumn = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("введите номер строки элемента ");
// int stringNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите номер столбца элемнта ");
// int columNumber = Convert.ToInt32(Console.ReadLine());

// void Printarray(double[,]matr)
// {
//     for(int i = 0; i < matr.GetLength(0); i++)
//     {
//         for(int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i,j]} ");
//         }
//         Console.WriteLine();
//     }

// }


// void Fillarray(double[,]matr)
// {
//     for(int i = 0; i < matr.GetLength(0); i++)
//     {
//         for(int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] = new Random().Next(-10,10);
//         }
//     }

// }

// double[,] matrix = new double[quantityString,quantityColumn];


// Fillarray(matrix);
// Printarray(matrix);

// if(quantityString < stringNumber | quantityColumn < columNumber)
// {
//     Console.WriteLine("такого элемента нет");
// }
// else
// {
//     double temp = matrix[stringNumber, columNumber];
//     Console.WriteLine(temp);
// }

Console.WriteLine("введите количество строк матрицы ");
int quantityString = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите количество столбцов матрицы ");
int quantityColumn = Convert.ToInt32(Console.ReadLine());


void Printarray(double[,]matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }

}


void Fillarray(double[,]matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(-10,10);
        }
    }

}

void AverageColumn(double[,]matr)
{
Console.WriteLine();
for (int j = 0; j < matr.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        sum = sum + matr[i, j];
    }
    Console.Write($"{ sum / matr.GetLength(0)} ");
}
}
double[,] matrix = new double[quantityString,quantityColumn];


Fillarray(matrix);
Printarray(matrix);
AverageColumn(matrix);

