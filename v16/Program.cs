
// string [] menu = { "bakso", "soto", "rawon", "rujak" };

// for (int i = 0; i <= 3; i++)
// {
//   Console.WriteLine(menu[i]);
// }

// menu[0] = "roti";
// Console.WriteLine(menu[0]);
// menu[0] = "es krim";
// Console.WriteLine(menu[0]);


string [] teman = new string[4];

for (int i = 0; i <= 3; i++)
{
  Console.Write($"Teman {i} : ");
  teman[i] = Console.ReadLine();
}

Console.WriteLine( $"nama yang dimasukan : " );
for (int i = 0; i <= 3; i++)
{
  Console.WriteLine(teman[i]);
}


