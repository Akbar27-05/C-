using App;

Rumus.tampil();

Rumus rumus = new Rumus();
Console.Write( "masukan jari : " );
int a = Convert.ToInt32( Console.ReadLine() );
rumus.set(a);

Console.Write($"jadi lias dari jari-jari : {a} adalah : ");
rumus.get();