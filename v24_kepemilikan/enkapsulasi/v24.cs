namespace v24
{
  class Kalkulator
  {
    private string tulisan = "rumus volume balok";

    public string tampil(){
      return this.tulisan;
    }

    protected int alas;

    public int kali(int a, int b){
      return this.alas = a * b;
    }
  }

  class Rumus:Kalkulator
  {
    public int balok( int t){
      return  this.alas * t;
    }
  }
}