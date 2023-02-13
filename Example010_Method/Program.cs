int[] array = { 1, 2, 3, 6, 56, 6, 8, 67 };

int n = array.Length;
int find = 6;

int index = 0;

while (index < n)
{

  if (array[index] == find)
  {
    Console.WriteLine(index);
    break;
  }

    index++;
}