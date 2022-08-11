int[] array = {1, 25, 35, 14, 25, 68, 7, 68};

int n = array.Length;
int find = 68;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}