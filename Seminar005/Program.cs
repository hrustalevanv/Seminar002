﻿/*Почувствуй себя мидлом
23. Показать таблицу квадратов чисел от 1 до N 
24. Найти кубы чисел от 1 до N
25. Найти сумму чисел от 1 до А
26. Возведите число А в натуральную степень B используя цикл
27. Определить количество цифр в числе
28. Подсчитать сумму цифр в числе
29. Написать программу вычисления произведения чисел от 1 до N
30. Показать кубы чисел, заканчивающихся на четную цифру
Почувствуй себя джуном

Почувствуй себя интерном
 0. Вывести квадрат числа
 1. По двум заданным числам проверять является ли первое квадратом второго
 2. Даны два числа. Показать большее и меньшее число
 3. По заданному номеру дня недели вывести его название
 4. Найти максимальное из трех чисел
 5. Написать программу вычисления значения функции y = f(a)
 6. Выяснить является ли число чётным
 7. Показать числа от -N до N
 8. Показать четные числа от 1 до N
 9. Показать последнюю цифру трёхзначного числа
10. Показать вторую цифру трёхзначного числа

11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
12. Удалить вторую цифру трёхзначного числа
13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
14. Найти третью цифру числа или сообщить, что её нет
15. Дано число. Проверить кратно ли оно 7 и 23
16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 
17. По двум заданным числам проверять является ли одно квадратом другого
18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
20. Задать номер четверти, показать диапазоны для возможных координат
21. Программа проверяет пятизначное число на палиндромом.
22. Найти расстояние между точками в пространстве 2D/3D
31. Задать массив из 8 элементов и вывести их на экран
32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
33.Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
Написать программу замену элементов массива на противоположные
Определить, присутствует ли в заданном массиве, некоторое число
Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
Найти сумму чисел одномерного массива стоящих на нечетной позиции
Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
*/
//31. Задать массив из 8 элементов и вывести их на экран
/*void func31(int n)
{
    int [] array31 = new int [n];
    for (int i =0; i < array31.Length; i++)
    {
        array31[i] = new Random().Next(10);
        Console.WriteLine(array31[i]);
    }
}
func31(8);
/*
 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
 
 void func31(int n)
{
    int [] array31 = new int [n];
    for (int i =0; i < array31.Length; i++)
    {
        array31[i] = new Random().Next(0,2);
        Console.WriteLine(array31[i]);
    }
}
func31(8);
33.Задать массив из 12 элементов, заполненных числами из [0,9].
 Найти сумму положительных/отрицательных элементов массива
// int func31(int n)
// {
//     int [] array31 = new int [n];
//     int Result = 0;
//     for (int i =0; i < array31.Length; i++)
//     {
//         array31[i] = new Random().Next(0,10);
//         Console.WriteLine(array31[i]);
//         Result = Result + array31[i];
//     }
//  return Result;
// }
// Console.WriteLine ($"Выводим сумму элемента {func31(12)}");

//34. Написать программу замену элементов массива на противоположные
// void func31(int n)
// {
//     int [] array31 = new int [n];
//     for (int i =0; i < array31.Length; i++)
//     {
//         array31[i] = new Random().Next(-3,3);
//         Console.WriteLine(array31[i]);
//     }
//   int [] array32 = new int [n];
//   for (int j = 0; j < array32.Length; j++)    
//   {
//       array32[j] = -array31[j];
//       Console.WriteLine(array32[j]);
//   }
// }
// func31(4);
//35. Определить, присутствует ли в заданном массиве, некоторое число
*/void func35(int n)
{
    int [] array33 = new int [n];
    for (int i =0; i < array33.Length; i++)
    {
        array33[i] = new Random().Next(0,10);
        Console.WriteLine(array33[i]);
        
    }
   bool check (int x)
   {
       for (int i =0; i < array33.Length; i++)
       {
         return array33[i] == x;
       }
 return false;
   }
}
Console.WriteLine(func35();
Console.WriteLine (check(5));