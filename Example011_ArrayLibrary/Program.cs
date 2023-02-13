Console.Clear();
void FillArray(int[] collection)
{
  int lenght = collection.Length;
  int index = 0;
  while (index < lenght)
  {
    collection[index] = new Random().Next(1, 10);

    index++;
  }

}

void PrintArray(int[] col)      //void-метод не возвращает
{
  int count = col.Length;
  int position = 0;
  while (position < count)
  {
    Console.WriteLine(col[position]);
    position++;
  }

}
//поиск позиции с помощью метода
int Indexof(int[] collection, int find)
{
  int count = collection.Length;
  int index = 0;
  int position = -1;//если элемента нет
  while (index < count)
  {
    if (collection[index] == find)
    {
      position = index;
      break;
    }
    index++;
  }
  return position;
}

int[] array = new int[10];

FillArray(array);
array[4] = 8;
array[6] = 8;
PrintArray(array);

Console.WriteLine();

int pos = Indexof(array, 43);
Console.WriteLine(pos);