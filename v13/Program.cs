Console.Write("Masukan Angka Awal : ");
int awal = Convert.ToInt32( Console.ReadLine() );
Console.Write("Masukan Angka Akhir : ");
int akhir = Convert.ToInt32( Console.ReadLine() );

Console.WriteLine();
Console.WriteLine("--------GENAP--------");

for (int i = awal; i <= akhir; i++)
{
  if (i % 2 == 0) // bil genap
  {
    Console.Write( $"{i} " );
  }
  
}

Console.WriteLine();
Console.WriteLine("--------GANJIL--------");

for (int i = awal; i <= akhir; i++)
{
  if (i % 2 == 1)
  {
    Console.Write( $"{i} " );
  }
}

Console.WriteLine();
Console.WriteLine("--------PRIMA--------");

for (int i = awal; i <= akhir; i++)
{
  if ( (i == 2) || (i == 3) || (i == 5) || (i != 1) && (i % 2 != 0) && (i % 3 != 0) && (i % 5 != 0) )
  {
    Console.Write( $"{i} " );
  }
}