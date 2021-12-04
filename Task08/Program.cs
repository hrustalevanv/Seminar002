//8. Показать четные числа от 1 до N
int start = 0;
int end = 20;
for (int i = start; i <= end; i++)
{
    if (i % 2 == 0)
    Console.WriteLine($"{i} ");
}