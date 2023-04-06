using v24;


Rumus rumus = new Rumus();
Console.WriteLine(rumus.tampil());
Console.Write("masukan panjang : ");
int p = Convert.ToInt32( Console.ReadLine() );
Console.Write("masukan lebar : ");
int l = Convert.ToInt32( Console.ReadLine() );
Console.Write("masukan tinggi : ");
int t = Convert.ToInt32( Console.ReadLine() );
rumus.kali(p,l);
Console.Write("Volume balok adalah : ");
Console.WriteLine(rumus.balok(t));