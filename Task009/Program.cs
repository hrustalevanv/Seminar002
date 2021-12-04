//9.Показать последнюю цифру трёхзначного числа 
int a = 123;
 void Main(int arg)
{
    string s = arg.ToString();
    Console.WriteLine ($"Выводим последнюю цифру {s[2]}" );
}
Main(a);