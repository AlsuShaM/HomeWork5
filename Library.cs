public static class Library
{
    // обязательно в новом файле прописываем 
    // using static Library


    // метод, который создаёт массив
    public static int[] CreateArray(int count)
    {
     return new int[count];
    }
    // int[] array = CreateArray(10);

    // заполняет массив
    public static void Fill(int[] array, int min, int max)
    { 
        int size = array.Length; 
        for (int i = 0; i < size; i++)
        {
            array[i] = Random.Shared.Next(min, max + 1);
            //array[i] = new Random().Next(min, max);
        }
    }
    // Fill(array, -5, 5);

    // печать массива
    public static string PrintGood(int[] numbers)
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
    // Console.WriteLine(PrintGood(array));

    // вычисление суммы положительных значений
    public static int SumPositive(int[] numbers)
    {
        int result = 0;
        int size = numbers.Length;
        for (int i = 0; i < size; i++)
        {
            if (numbers[i] > 0) result += numbers[i];
        }
        return result;
    }
    // int pos = SumPositive(col);
    // Console.WriteLine($">0 {pos}");

    // вычисление суммы отрицательных значений
    public static int SumNegative(int[] numbers)
    {
        int result = 0;
        int size = numbers.Length;
        for (int i = 0; i < size; i++)
        {
            if (numbers[i] < 0) result += numbers[i];
        }
        return result;
    }
    // int neg = SumNegative(col);
    // Console.WriteLine($"<0 {neg}");

    // метод упорядочивания элементов
    public static void SelectionSort(int[] array)
    {
        for(int i = 0; i < array.Length - 1; i++)
        {
            int minPosition = i;
            for(int j = i + 1; j < array.Length; j++)
            {
                if(array[j] < array[minPosition]) minPosition = j;
            }
            int temporary = array[i];
            array[i] = array[minPosition];
            array[minPosition] = temporary;
        }
    }
    //SelectionSort(array);

    //подсчет четных элементов
    public static int EvenNumbers(int[] array)
    {
        int result = 0;
        int size = array.Length;
        for (int i = 0; i < size; i++)
        {
            if((array[i] % 2) == 0) result++; ;
        }
        return result;
    }
    //int result = EvenNumbers(array);
    //Console.WriteLine($"-> {result}");

    //сумма элементов, стоящих на нечётных позициях
    public static int OddIndex(int[] array)
    {
        int result = 0;
        int size = array.Length;
        for (int i = 1; i <= size; i = i + 2)
        {
            result = result + array[i];
        }
        return result;
    } 
    //int result = OddIndex(array);
    //Console.WriteLine($" -> {result}");

    //задать массив вещественных чисел
    public static void Fill(double[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Shared.NextDouble() * 10; //*10 чтобы числы были с двумя знаками после запятой 0,00
        }
    }
    //double[] array = new double[10];
    //Fill(array);

    //найти макс и мин элемент
    public static double MinElement(double[] array)
    {
        double min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if(min > array[i]) min = array[i];
        }
        return min;
    }
    public static double MaxElement(double[] array)
    {
        double max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if(max < array[i]) max = array[i];
        }
        return max;
    }
    //Console.WriteLine($"min = {MinElement(array):F2}");
    //Console.WriteLine($"max = {MaxElement(array):F2}");

    //найти разницу между макс и мин
    public static double Diff(double[] array)
    {
        return MaxElement(array) - MinElement(array);
    }
    //Console.WriteLine($"Разница между max и min элементами -> {Diff(array):F2}");
}