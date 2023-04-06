int tampil(){

  Console.Write("masukan a : ");
  int a = Convert.ToInt32( Console.ReadLine() );
  Console.Write("masukan b : ");
  int b = Convert.ToInt32( Console.ReadLine() );
  int c = a * b;
  return c;
}

Console.WriteLine( tampil() );

// tampil();