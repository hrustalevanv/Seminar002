//11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
void array1(int arg)
{
    string s = arg.ToString();

    int i1 = (int)(s[0] -'0'); 
    int i2 = (int)(s[1] -'0');

   Console.WriteLine($"s[0] = {s[0]}");  
   Console.WriteLine($"s[1] = {s[1]}");

  if(i1 > i2)
  {
      Console.WriteLine($"Max = {i1}");
  }

  if(i2 > i1)
  {
      Console.WriteLine($"Max = {i2}");
  }
}
array1(83);