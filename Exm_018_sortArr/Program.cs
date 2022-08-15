// Сортировка массива

int[] arr = { 1, 5, 3, 6, 1, 1, 5 };

void printArr(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void selectionSort (int[] array)
{
 for (int i = 0; i < array.Length-1; i++)
    {
       int minPos = i;
       for (int j = i+1; j < array.Length; j++)
       {
           if(array[j]< array[minPos]) minPos = j;
       }
       int temporary = array[i];
       array[i] = array [minPos];
       array [minPos] = temporary;
    }   
}
printArr(arr);
selectionSort (arr);
printArr(arr);