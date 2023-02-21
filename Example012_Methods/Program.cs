// Вид1
void Method1()
{
  Console.WriteLine();
}
Method1(); //Вызов метода





//Вид2
void Method2(string msg)
{
  Console.WriteLine(msg);
}
Method2("Текст сообщения");

void Method21(string msg, count)
{
    iny i=0;
    while (i < count)
    {
      Console.WriteLine(msg);
      i++;
    }
}
//Method21(msg: "Текст", count:4);
Method21(count:4, msg:"новый текст");


//Вид3

int Method3()
{
  return DateTime.Now.Year;

}
int year = Method3();
Console.WriteLine(year);


//Вид4

string Method4(int count, string c)
{
    i = 0;
    string result = String.Empty;
    while(i < count)
    {
      result=result + c;
      i++;
    }
  return result;
}

string res = Method4(10 , "asdf");
Console.WriteLine(res);
