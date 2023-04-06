// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

string nama;
Console.Write("nama anda : ");
nama = Console.ReadLine();

Console.Write("umur anda : ");
int umur = Convert.ToInt32( Console.ReadLine() );

Console.Write("tinggi anda : ");
double tinggi = Convert.ToDouble( Console.ReadLine() );

Console.WriteLine(nama);
Console.WriteLine(umur);
Console.WriteLine(tinggi);

// guna convert untuk menggubah yang pada dasarnya bernilai string dapat di ubh menjadikan variable lain