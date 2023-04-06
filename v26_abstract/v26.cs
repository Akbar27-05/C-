namespace v26
{
  abstract class Kalkulator // cara menampilkan isi class abstract dengan cara mewariskan ke class lain
  {
    public void tampil(){
      Console.WriteLine("------Menghitung luas persegi------");
    }

    public int kali(int a, int b){
      return a * b;
    }
  }

  class Rumus:Kalkulator
  {
    public int persegi(int p, int l){
      return kali(p,l);
    }
  }
}