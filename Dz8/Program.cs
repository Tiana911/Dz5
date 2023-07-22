// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите размерность m массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность n массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[m,n];

void mas(int m, int n)
{
    int i,j;
    Random rand = new Random();
    for (i = 0; i < m; i++)
    {
        for (j = 0; j < n; j++)
        randomArray[i,j] = rand.Next(1,10);
        }
}

void printm(int[,] array)
{
    int i,j;
    for (i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
            Console.WriteLine();
     }
}

mas(m,n);
Console.WriteLine("Исходный массив: ");
printm(randomArray);

// Функция, считающая сумму элементов в строке
int SumLine(int[,] array, int i)
{
    int sum = array[i,0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[i,j];
    }
        return sum;
}

int minSum = 1;
int sum = SumLine(randomArray, 0);
for (int i = 1; i < randomArray.GetLength(0); i++)
{
    if (sum > SumLine(randomArray, i))
    {
        sum = SumLine(randomArray, i);
        minSum = i+1;
    }
}
Console.WriteLine($"Строка c наименьшей суммой элементов: {minSum}");