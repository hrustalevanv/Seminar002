//4. Найти максимальное из трех чисел
int a = 12;
int b = 17;
int c = 13;
if (a>b && a>c)
Console.WriteLine($"Наибольшее {a} ");
if (a<b && b>c)
Console.WriteLine($"Наибольшее {b} ");
if (c>b && a<c)
Console.WriteLine($"Наибольшее {c} ");
