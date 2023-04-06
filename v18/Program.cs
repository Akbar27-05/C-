
void hello(){
  Console.WriteLine("Hello, World!");
}

// hello();

void tambah(){
  Console.Write("masukan a : ");
  int a = Convert.ToInt32( Console.ReadLine() );
  Console.Write("masukan b : ");
  int b = Convert.ToInt32( Console.ReadLine() );
  int c = a + b;
  Console.WriteLine($"{a} + {b} = {c}");
}

tambah();


