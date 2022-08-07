int[] array = {16, 28, 34, 54, 36, 16, 68, 25, 36};
int n = array.Length;
int index = 0;
int find = 36;

while(index < n)
{
    if (array[index] == find) Console.WriteLine($"В массиве есть число {find}, под индексом - {index}."); 
    break;
    index++;
}

