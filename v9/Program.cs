// int kkm = 80;
// int nilai = 80;

// String hasil = ( nilai >= kkm ) ? "LULUS" : "TIDAK LULUS";
// Console.WriteLine(hasil);

// int tanggal = 10;
// hasil = ( (tanggal > 0) && (tanggal < 32) ) ? "TANGGAL BENAR" : "TANGGAL SALAH";
// Console.WriteLine( hasil );

Console.Write("masukan tanggal : ");
int tgl = Convert.ToInt32( Console.ReadLine() );
Console.Write("masukan bulan : ");
int bln = Convert.ToInt32( Console.ReadLine() );
String hasil = ( (tgl < 32) && (tgl > 0) && (bln < 13) && (bln > 0) ) ? "Benar" : "Salah";
Console.WriteLine( $"tanggal {tgl}, bulan {bln}, adalah = {hasil}" );