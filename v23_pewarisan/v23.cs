namespace v23
{
  class Kalkulator
  {
    public double kali(double a, double b){
      return a * b;
    }
  }

  class Rumus:Kalkulator // pewarisan menggambil class lain
  {
    public void lingkaran(){
      Console.WriteLine("lingkaran");
    }

    public double persegiPanjang(double p, double l){
      return p * l;
    }
  }
}