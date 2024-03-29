void bubbleSort(int[] array)
{
    var size = array.Length;
    for (int i = 0; i < size - 1; i++)
    {
        //var swapped = 0;
        for (int j = 0; j < size - i - 1; j++ )
        {
            if (array[j] > array[j+1])
            {
                var temp = array[j];
                array[j] = array[j+1];
                array[j+1] = temp;
                //swapped = 1;
            }
        }
        //if (swapped == 0) break; 
    }
}

//int[] numbers = { 0, -7, -51, 100, 5 };
int[] numbers = { 1, 3, 4, 5, 6, 7, 8, 9 };
bubbleSort(numbers);
foreach (int num in numbers)
{
    Console.WriteLine(num);
}

//int[] cheating = { 0, -7, -51, 100, 5 };
//Array.Sort(cheating);
//foreach (int num in cheating)
//{
//    Console.WriteLine(num);
//}