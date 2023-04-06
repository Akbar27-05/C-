// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// int a = 5;
// int b = 2;
// double c = 3;

// int tambah = a + b;
// Console.WriteLine(tambah);

// int kurang = a - b;
// Console.WriteLine(kurang);

// int kali = a * b;
// Console.WriteLine(kali);

// int bagi = a / b;
// Console.WriteLine(bagi);

// int sisa = a % b;
// Console.WriteLine(sisa);

// double pecahan = a / c;
// Console.WriteLine(pecahan);

Console.Write("Masukan bil a : ");
int a = Convert.ToInt32( Console.ReadLine() );
Console.Write("Masukan bil b : ");
int b = Convert.ToInt32( Console.ReadLine() );
Console.Write("Masukan bil c : ");
double c = Convert.ToDouble( Console.ReadLine() );

int tambah = a + b;
Console.WriteLine( $"{a} + {b} = {tambah}" );

int kurang = a - b;
Console.WriteLine( $"{a} - {b} = {kurang}" );

int kali = a * b;
Console.WriteLine( $"{a} x {b} = {kali}" );

int bagi = a / b;
Console.WriteLine( $"{a} / {b} = {bagi}" );

int sisa = a % b;
Console.WriteLine( $"{a} % {b} = {sisa}" );

double pecahan = a / c;
Console.WriteLine( $"{a} / {b} = {pecahan}" );
