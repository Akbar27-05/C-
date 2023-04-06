namespace v25
{
  class Kalkulator
  {

    private double bil_1;
    private double bil_2;

// konstruktor adalah sebuah method yg bisa langsung dijalankan ketika membuat objek, dilarang menggunakan void atau tipe data
// dan nama method harus sama dengan nama class
    public Kalkulator(double a, double b){
      bil_1 = a;
      bil_2 = b;
    }

    public double hitung(char opr){
      double hasil;

      switch (opr)
      {
        case '+':
          hasil = bil_1 + bil_2;
        break;
        case '-':
          hasil = bil_1 - bil_2;
        break;
        case '*':
          hasil = bil_1 * bil_2;
        break;
        case '/':
          hasil = bil_1 / bil_2;
        break;
        default:
          hasil = 0;
        break;
      }
      return hasil;
    }
  }
}