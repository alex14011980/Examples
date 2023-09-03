int[] array = {11, 52, 91, 44, 75, 61, 27, 18, 91};

int n = array.Length;
int find = 91;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }

    index++; 
}