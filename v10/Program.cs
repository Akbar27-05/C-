
string hasil;

Console.Write("masukan tanggal : ");
int tanggal = Convert.ToInt32( Console.ReadLine() );
Console.Write("masukan bulan : ");
int bulan = Convert.ToInt32( Console.ReadLine() );

if (tanggal > 0 && tanggal < 32 && bulan > 0 && bulan < 13) // jika kondisi benar maka akan lanjut masuk, jika salah langsung loncat
{
  hasil = "benar";
}else {
  hasil = "salah";
}

Console.WriteLine( $"tanggal {tanggal}, bulan {bulan}. adalah {hasil}" );
