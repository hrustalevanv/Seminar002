// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
void cratno (int chislo, int zadanoe)
{
   double ostatok = chislo % zadanoe;
   if (ostatok == 0)
   {
       Console.WriteLine ($"Кратно");
   }
   else 
   {
       Console.WriteLine (ostatok); 
   }
}

cratno(10,6);