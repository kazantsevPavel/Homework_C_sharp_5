// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите длинну массива");
int len = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(len);

int[] CreateArray(int n) // Создание случайного массива
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

PrintArray(myArray);

void PrintArray(int[] array)
{
    foreach (int el in array)
        System.Console.Write($"{el} ");
    System.Console.WriteLine();
}


int sumEvenIndNum(int[] array)

{
    int sum = 0;
    for (int i = 0; i < array.Length; i = i + 2)
        sum += array[i];
    return sum;
}
System.Console.WriteLine("Сумма всех чисел, стоящих на четных позициях равна: " + sumEvenIndNum(myArray));
