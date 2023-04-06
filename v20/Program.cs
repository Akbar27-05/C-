
// int kali( int a, int b ){
//   int c = a * b;

//   return c;
// }

// Console.WriteLine( kali(10,2) );

bool tanggal( int t ){
  if (t > 0 && t < 32)
  {
    return true;
  }else
  {
    return false;
  }
}

bool bulan( int b ){
  if (b > 0 && b < 13)
  {
    return true;
  }else
  {
    return false;
  }
}

Console.Write("masukan tanggal : ");
int tgl = Convert.ToInt32( Console.ReadLine() );
Console.Write("masukan bulan : ");
int bln = Convert.ToInt32( Console.ReadLine() );
if (tanggal(tgl) && bulan(bln))
{
  Console.WriteLine("tanggal bulan benar");
}else
{
  Console.WriteLine("tanggal bulan salah");
}
