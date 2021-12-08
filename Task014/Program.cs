// 14. Найти третью цифру числа или сообщить, что её нет
void estli3(int arg)
{
    if (arg < 0)
      arg = arg * (-1);
      string s = arg.ToString();
    if (s.Length >= 3)
      Console.WriteLine(s[2]);
    else 
      Console.WriteLine($"Цифры нет");
}

estli3(123);