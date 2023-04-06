Console.Write("masukan bilangan awal : ");
int awal = Convert.ToInt32( Console.ReadLine() );
Console.Write("masukan bilangan akhir : ");
int akhir = Convert.ToInt32( Console.ReadLine() );

int i = awal;

Console.WriteLine("--------GENAP--------");

i = awal;
while (i <= akhir)
{
  if (i % 2 == 0)
  {
    Console.Write( $"{i} " );
  }
  i++;
}

Console.WriteLine();
Console.WriteLine("--------GANJIL--------");

i = awal;
while (i <= akhir)
{
  if (i % 2 == 1)
  {
    Console.Write( $"{i} " );
  }
  i++;
}

Console.WriteLine();
Console.WriteLine("--------PRIMA--------");

i = awal;
while (i <= akhir)
{
  if ( (i == 2) || (i == 3) || (i == 5) || (i != 1) && (i % 2 != 0) && (i % 3 != 0) && (i % 5 != 0) )
  {
    Console.Write( $"{i} " );
  }
  i++;
}
