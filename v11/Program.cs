Console.Write("masukan nilai : ");
int nilai = Convert.ToInt32( Console.ReadLine() );
int kkm = 80;

if (nilai >= 0 && nilai <= 100)
{
  if (nilai > kkm)
  {
    Console.WriteLine("LULUS");
  }else
  {
    Console.WriteLine("BELUM LULUS");
  }
}else
{
  Console.WriteLine("Nilai Salah");
}
