
// string [,] siswa = {  {"budi", "surabaya"}, {"ali", "sidoarjo"}, {"siti", "malang"} };

// for (int i = 0; i < 3; i++)
// {
//   for (int j = 0; j < 2; j++)
//   {
//     Console.Write(siswa[i,j] + "  ");
//   }
//   Console.WriteLine();
// }


string [,] buah = new string[4,2];
for (int i = 0; i < 4; i++)
{
  for (int j = 0; j < 2; j++)
  {
    // if (j == 0)
    // {
    //   Console.Write("buah : ");
    //   buah[i,j] = Console.ReadLine();
    // }else
    // {
    //   Console.Write("harga : ");
    //   buah[i,j] = Console.ReadLine();
    // }

    string tampil = j == 0 ? "Buah : " : "Harga : ";
    Console.Write(tampil);
    buah[i,j] = Console.ReadLine();
  }
} 

Console.WriteLine("-----------Tampil Menu Buah-----------");
for (int i = 0; i < 4; i++)
{
  for (int j = 0; j < 2; j++)
  {
    Console.Write(buah[i,j] + " " );
  }
  Console.WriteLine();
}
