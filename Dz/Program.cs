// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.


// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] result = new int[size];
// int count = 0;
// FillArrayRandomNumbers(result);
// PrintArray(result);
// for (int i = 0; i < result.Length; i++)
// {
//     if (result[i] % 2 == 0)
//     count++;
// }
// Console.WriteLine($"количество чётных чисел в массиве: {count} ");
// void FillArrayRandomNumbers(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100,1000);
//     }
// }
// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }


// Задача 36: Задайте одномерный массив, заполненный случайными 
// числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int size = 4;
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);

// int sumNumbersEvenIndex = 0;

// for (int i = 1; i < numbers.Length; i += 2)
// {
//     sumNumbersEvenIndex += numbers[i];
// }
// Console.Write(sumNumbersEvenIndex);



// void FillArrayRandomNumbers(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-100, 101);
//     }
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// ежду максимальным и минимальным элементов массива.

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] numbers = new double[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Вот наш массив: ");
// PrintArray(numbers);
// double min = Int32.MaxValue;
// double max = Int32.MinValue;

// for (int z = 0; z < numbers.Length; z++)
// {
//     if (numbers[z] > max)
//     {
//         max = numbers[z];
//     }
//     if (numbers[z] < min)
//     {
//         min = numbers[z];
//     }
// }

// void FillArrayRandomNumbers(double[] numbers)
// {
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
//     }
// }
// void PrintArray(double[] numbers)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }