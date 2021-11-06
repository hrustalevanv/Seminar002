//2.Даны два числа. Показать большее и меньшее число
Console.Clear();
int x,y;
Console.WriteLine("Укажите целое x");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите целое y");
y = Convert.ToInt32(Console.ReadLine());
if (x>y)
{
   Console.WriteLine($"Max= {x}");
   Console.WriteLine($"Min= {y}");
}
else
{
  Console.WriteLine($"Max= {y}");
  Console.WriteLine($"Min= {x}"); 
}


