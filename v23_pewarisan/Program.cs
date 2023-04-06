using v23;

// Rumus rumus = new Rumus(); // menggunakan pewarisan dapat menggambil isi class lain
// rumus.tambah();
// rumus.tambah();
// rumus.lingkaran();

Console.Write("masukan panjang : ");
double p = Convert.ToDouble( Console.ReadLine() );
Console.Write("masukan lebar : ");
double l = Convert.ToDouble( Console.ReadLine() );

Rumus kal = new Rumus(); // hanya bisa mengambil isi class sendiri
Console.Write($"{p} * {l} = ");

kal.persegiPanjang(p,l);