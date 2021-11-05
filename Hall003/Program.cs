//0. Вывести квадрат числа
 //1. По двум заданным числам проверять является ли первое квадратом второго
 //2. Даны два числа. Показать большее и меньшее число
 //3. По заданному номеру дня недели вывести его название
 //4. Найти максимальное из трех чисел
 //5. Написать программу вычисления значения функции y=f(a)
 //6. Выяснить является ли число чётным
 //7. Показать числа от -N до N
 //8. Показать четные числа от 1 до N
// 9. Показать последнюю цифру трёхзначного числа
//10. Показать вторую цифру трёхзначного числа
//11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
//12. Удалить вторую цифру трёхзначного числа
//13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
//14. Найти третью цифру числа или сообщить, что её нет


//0. Вывести квадрат числа
int a = 2;
Console.WriteLine($"Выводим квадрат числа {a*a}");

/*1. По двум заданным числам проверять является ли первое квадратом второго
//int a = 3;
//int b = 9;
//if (b == a*a)
//Console.WriteLine(b);

 //Даны два числа. Показать большее и меньшее число
//Console.Clear();
//int x,y,max,min;
//Console.WriteLine("Укажите целое x");
//x = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Укажите целое y");
//y = Convert.ToInt32(Console.ReadLine());
//if (x>y)
//{
  // max=x;
   //min=y;
//}
//else
//{
  // max=y;
   //min=x;
//}
//Console.WriteLine($"Max={max}");
//Console.WriteLine($"Min= {min}");

//3. По заданному номеру дня недели вывести его название
int day = 6;
if (day == 1)
{
    Console.WriteLine("Понедельник");
}
if (day == 2)
{
    Console.WriteLine("Вторник");
}
if (day == 3)
{
    Console.WriteLine("Среда");
}
if (day == 4)
{
    Console.WriteLine("Четверг");
}
if (day == 5)
{
    Console.WriteLine("Пятница");
}
if (day == 6)
{
    Console.WriteLine("Суббота");
}
if (day == 7)
{
    Console.WriteLine("Воскресенье");
}
//int index = 0;
//int[] array = new int[3];
// Заполняет массив
/*while (index < 3)
{
    array[index] = new Random().Next(3, 6); 
    index++;
}
/*index = 0;
// печатаем массив
//while (index < 3)
//{
   // int val = array[index];
   // Console.WriteLine(val);
   // index++;
//}
//index = 0;
//while (index < 3)
//{
   // int val = array[index];
   // Console.WriteLine(val);
   // index++;
//}
//Console.WriteLine();
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
//5. Написать программу вычисления значения функции y=f(a)
double a = 0;
double y = Math.Sin(a);
Console.WriteLine(y);
//6. Выяснить является ли число чётным
int one = 14;
if(one % 2 == 0)
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Нечетное");
}
//7. Показать числа от -N до N
int start = -10;
int end = 10;
for (int i = start; i <= end; i++)
{
    Console.Write($"{i} ");
}
*/
