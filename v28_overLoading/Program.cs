using v28;

Rumus rum = new Rumus();
Console.WriteLine("---------persegi--------");
Console.Write("masukan sisi persegi : ");
int s = Convert.ToInt32( Console.ReadLine() );
Console.Write("jadi hasil perhitungan sisi persegi adalah = ");
Console.WriteLine( rum.persegi(s) );
Console.WriteLine();

Console.WriteLine("--------Persegi Panjang--------");
Console.Write("masukan panjang : ");
int p = Convert.ToInt32( Console.ReadLine() );
Console.Write("masukan luas : ");
int l = Convert.ToInt32( Console.ReadLine() );
Console.Write($"jadi hasil dari p = {p} dan l = {l} adalah = ");
Console.WriteLine( rum.persegi(p,l) );

