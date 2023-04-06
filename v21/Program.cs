using v21; // using digunakan untuk mengambil isi file lain seperti ( requaire_once pada PHP )

Kalkulator hitung = new Kalkulator();

// hitung.tambah();
// hitung.kurang();

Console.Write("masukan panjang : ");
int p = Convert.ToInt32( Console.ReadLine() );
Console.Write("masukan lebar : ");
int l = Convert.ToInt32( Console.ReadLine() );

Rumus isi = new Rumus();
int luas = isi.persegiPanjang(p,l);

Console.WriteLine( $"{p} * {l} = {luas} " );