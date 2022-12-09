// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите длинну массива");
int len = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(len);

int[] CreateArray(int n) // Создание случайного массива
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (int el in array)
        System.Console.Write($"{el} ");
    System.Console.WriteLine();
}

PrintArray(myArray);

int CountEvenNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    { if (array[i] % 2 == 0) count++; }
    return count;
    
}

Console.WriteLine("В этом массиве вот столько чётных чисел: " + CountEvenNum(myArray));



