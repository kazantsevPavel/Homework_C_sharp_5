// Задача 38: Задайте массив случайных вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


Console.WriteLine("Введите длинну массива");
int len = Convert.ToInt32(Console.ReadLine());
double [] myArray = CreateArray(len);

double[] CreateArray(int n) // Создание случайного массива
{
    double[] array = new double [n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(-99,100);
        array[i] /=10;
    }
    return array;
}

void PrintArray(double[] array)
{
    foreach (double el in array)
        System.Console.Write($"{el} ");
    System.Console.WriteLine();
}

PrintArray(myArray);


double MaxAndMinNum (double[] array)
{
double max = array[0];
int indexMax = 0;
double min = array[0];
int indexMin = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
        indexMax = i;
    }
     if (array[i] < min)
    {
        min = array[i];
        indexMin = i;
    }

}
double diff = max - min;
System.Console.WriteLine($"Разница между max {max} и min {min} = {diff}");
return diff; 

}

MaxAndMinNum(myArray);


// Random rnd = new Random();
// double d = rnd.NextDouble();