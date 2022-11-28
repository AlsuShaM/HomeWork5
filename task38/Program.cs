// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//задать массив вещественных чисел
void Fill(double[] array)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.NextDouble() * 10;
    }
}
//печать массива
string PrintGood(double[] array)
{
    int size = array.Length;
    int i = 0;
    string result = "[ ";

    while (i < size)
    {
        result += ($"{array[i]:F2} ");
        i++;
    }
    return result + "]";
}

//найти макс и мин элемент
double MinElement(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(min > array[i]) min = array[i];
    }
    return min;
}
double MaxElement(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(max < array[i]) max = array[i];
    }
    return max;
}

//найти разницу
double Diff(double[] array)
{
    return MaxElement(array) - MinElement(array);
}


double[] array = new double[10];
Fill(array);
Console.WriteLine(PrintGood(array));
Console.WriteLine($"min = {MinElement(array):F2}");
Console.WriteLine($"max = {MaxElement(array):F2}");
Console.WriteLine($"Разница между max и min элементами -> {Diff(array):F2}");



