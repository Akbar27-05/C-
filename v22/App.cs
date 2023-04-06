namespace App
{
  class Rumus {

    public double hasil;

    public static void tampil(){ // static jika di panggil bisa langsung ( NAMA CLASS DAN METHOD contoh "Rumus.tampil()" )
      Console.WriteLine("program luas lingkaran");
    }

    public double set(int a){ // method static tidak boleh digabung dgn this.  nanti erorrrrrrr
      return this.hasil = a * a * 3.14; // this. digunakan untk memanggil nama method lain ke dalam method
    }

    public void get(){
      Console.WriteLine(this.hasil);
    }

  } 
  
}