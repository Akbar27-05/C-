using v25;

Console.Write("masukan bil 1 : ");
double a = Convert.ToDouble( Console.ReadLine() );
Console.Write("masukan bil 2 : ");
double b = Convert.ToDouble( Console.ReadLine() );

Kalkulator kal = new Kalkulator(a,b);

Console.Write("masukan oprator ( +, -, *, / ) : ");
char op = Convert.ToChar( Console.ReadLine() );

Console.Write($"{a} {op} {b} = ");

Console.WriteLine( kal.hitung(op) );

