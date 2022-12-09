// Задача HARD STAT необязательная:
//  Задайте массив случайных целых чисел.
//  Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, среднее арифметическое всех элементов. 
//  Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями.
//  Найти медианное значение первоначалального массива , возможно придется кое-что для этого дополнительно выполнить.

Console.WriteLine("Введите длинну массива");
int len = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(len);

int[] CreateArray(int n) // Создание случайного массива
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(1, 20);
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (int el in array)
        System.Console.Write($"{el} ");
    System.Console.WriteLine();
}
System.Console.WriteLine("Был сгенерирован массив:");
PrintArray(myArray);



int[] MaxAndMinNum(int[] array) // ищем минимумы и максимумы
{
    int max = array[0];
    int indexMax = 0;
    int min = array[0];
    int indexMin = 0;
    int[] maxMin = new int[4];

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
        maxMin[0] = max;
        maxMin[1] = indexMax;
        maxMin[2] = min;
        maxMin[3] = indexMin;
    }
    return maxMin;
}
System.Console.WriteLine ("Самый большой элемент и его индекс, самый маленькмий элемент и его индекс: ");
PrintArray(MaxAndMinNum(myArray));

int ArithmeticMean(int[] array) // поиск среднего арифметического
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        {sum += array[i];}
    int arithmeticMean = sum/array.Length;
    return arithmeticMean;
}

System.Console.WriteLine("Среднее арифметическое: " + ArithmeticMean(myArray));


int[] BubbleSort(int[] mas) // сортировка
{
    int temp;
    for (int i = 0; i < mas.Length; i++)
    {
        for (int j = i + 1; j < mas.Length; j++)
        {
            if (mas[i] > mas[j])
            {
                temp = mas[i];
                mas[i] = mas[j];
                mas[j] = temp;
            }
        }
    }
    return mas;
}

// PrintArray(BubbleSort(myArray));
int[] arraySorting = BubbleSort(myArray);

double Mediana (int[] array)
{
double mediana = array[array.Length/2];
if (array.Length%2 == 0)
{
mediana = array[array.Length/2] + array[(array.Length/2)-1];
mediana = mediana/2;
}

return mediana;
}

double mediana = Mediana(arraySorting);
System.Console.WriteLine("Медиана: "+ mediana);

