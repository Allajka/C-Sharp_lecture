void creatArray (int[] newArray)
{
    int length = newArray.Length;
    int insex = 0;
    while(insex < length)
    {
        newArray[insex] = new Random().Next(1, 9);
        insex++;
    }
}

void printArray (int[] col)
{
    int size = col.Length;
    int position = 0;
    while (position<size)
    {
        Console.Write(col[position]);
        position++;
    }
}

int indexF(int[] collection, int find)
{
    int count = collection.Length;
    int idex = 0;
    int position = -1;
    while (idex<count)
    {
        if (collection[idex] == find) 
        {
            position = idex;
            break;
        }
        idex++;
    }
    return position;
}
int [] array = new int [10];

creatArray(array);
printArray(array);
Console.WriteLine(""); 
int pos = indexF (array, 3);
Console.WriteLine(pos); 