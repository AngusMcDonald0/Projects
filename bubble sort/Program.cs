void bubbleSort(int[] array)
{
    var size = array.Length;
    for (int i = 0; i < size - 1; i++)
    { 
        for (int j = 0; j < size - i - 1; j++ )
        {
            if (array[j] > array[j+1])
            {
                var temp = array[j];
                array[j] = array[j+1];
                array[j+1] = temp;
            }
        }
    }
}

int[] numbers = { 0, -7, -51, 100, 5 };
bubbleSort(numbers);
foreach (int num in numbers)
{
    Console.WriteLine(num);
}

int[] cheating = { 0, -7, -51, 100, 5 };
Array.Sort(cheating);
foreach (int num in cheating)
{
    Console.WriteLine(num);
}