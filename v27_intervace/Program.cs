using v27;

Kalkulator kal = new Kalkulator();
kal.judul("menghitung lus persegi");

// Console.WriteLine( kal.kali(2,3) );
// Console.WriteLine( kal.tambah(2,3) );

Console.Write("masukan panjang : ");
int p = Convert.ToInt32( Console.ReadLine() );
Console.Write("masukan lebar : ");
int l = Convert.ToInt32( Console.ReadLine() );

Console.Write($"luas persegi dari p = {p} dan l = {l} adalah : ");
Console.WriteLine( kal.kali(p,l) );
