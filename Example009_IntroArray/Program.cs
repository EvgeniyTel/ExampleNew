int Max(int arg1, int arg2, int arg3)
{
  int rezult = arg1;
  if (arg2 > rezult) rezult = arg2;
  if (arg3 > rezult) rezult = arg3;
  return rezult;
}

int[] array ={11, 21, 34, 45, 464, 234, 32, 343, 211};
array[0] = 12;


int max = Max(
  Max(array[0],array[1],array[2]),
  Max(array[3],array[4],array[5]),
  Max(array[6],array[7],array[8]));

Console.WriteLine(max);