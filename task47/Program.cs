 //Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int m = 3;
int n = 4;

double[,] array = new double[m, n];

void DoblArray(double[,] domn)
{
    for (int i = 0; i < domn.GetLength(0); i++)
    {
        for (int j = 0; j < domn.GetLength(1); j++)
        {
            domn[i, j] = new Random().NextDouble();
        }
    }
}

void Print(double[,] domn)
{
    for (int i = 0; i < domn.GetLength(0); i++)
    {
        for (int j = 0; j < domn.GetLength(1); j++)
        {
            Console.Write($" {domn[i, j]} ");

        }
        Console.WriteLine();
    }
}
DoblArray(array);
Print(array);
