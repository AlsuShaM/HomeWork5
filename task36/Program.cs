// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

//создать массив
int[] Array(int count)
    {
     return new int[count];
    }

//заполнить случайными числами
void Fill(int[] array, int min, int max)
{ 
    int size = array.Length; 
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
}

string PrintGood(int[] numbers)
{
    int size = numbers.Length;
    int i = 0;
    string result = "[ ";

    while (i < size)
    {
        result += ($"{numbers[i],3} ");
        i++;
    }
    return result + "]";
}

//найти сумму нечетных позиции
int OddIndex(int[] array)
{
    int result = 0;
    int size = array.Length;
    for (int i = 1; i <= size; i = i + 2)
    {
        result = result + array[i];
    }
    return result;
}

int[] array = Array(10);
Fill(array, -5, 5);
int result = OddIndex(array);
Console.WriteLine($"{PrintGood(array)} -> {result}");