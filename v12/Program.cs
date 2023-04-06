Console.Write("masukan angka a : ");
int a = Convert.ToInt32( Console.ReadLine() );
Console.Write("masukan angka b : ");
int b = Convert.ToInt32( Console.ReadLine() );
Console.WriteLine("masukan menu ");
int menu = Convert.ToInt32( Console.ReadLine() );

switch (menu)
{
  case 1:
  Console.WriteLine(a+b);
  break;

  case 2:
  Console.WriteLine(a-b);
  break;

  case 3:
  Console.WriteLine(a*b);
  break;

  case 4:
  Console.WriteLine(a/b);
  break;

  default:
  Console.WriteLine("menu tidak ada");
  break;
}