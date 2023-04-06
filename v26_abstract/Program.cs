using v26;

Rumus rumus = new Rumus();

rumus.tampil();

Console.Write("masukan panjang : ");
int p = Convert.ToInt32( Console.ReadLine() );
Console.Write("masukan lebar : ");
int l = Convert.ToInt32( Console.ReadLine() );

Console.Write( $"jadi luas persegi dari p : {p} dan l : {l} adalah = " );
Console.WriteLine( rumus.persegi(p,l) );
