// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


int[] CreateArray(int count)
    {
     return new int[count];
    }

void Fill(int[] array, int min, int max)
{ 
    int size = array.Length; 
    for (int i = 0; i < size; i++)
    {
        //array[i] = Random.Shared.Next(min, max + 1);
        array[i] = new Random().Next(min, max+ 1);
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

int Multiple(int[] array)
{
    int result = 0;
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        if((array[i] % 2) == 0) result++; ;
    }
    return result;
}

int[] array = CreateArray(10);
Fill(array, 100, 999);
int result = Multiple(array);
Console.WriteLine($"{PrintGood(array)} -> {result}");