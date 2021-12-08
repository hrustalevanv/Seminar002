// 12. Удалить вторую цифру трёхзначного числа
void Main(int arg)
{
    string a = arg.ToString();
    int b = (int)(a[0] -'0'); 
    int s = (int)(a[2] -'0');
    Console.WriteLine(b * 10 + s );
}
void perebor(int i)
{
   for(; i < 306; i++)
  {
     Main(i);
  }
}
perebor(295);