// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// // or and not
// bool atau = true || false || false;
// Console.WriteLine(atau);

// bool dan = true && true && false;
// Console.WriteLine(dan);

// bool tidak = !true; // kebalikan
// Console.WriteLine(tidak);

Console.Write("masukan bulan : ");
int bulan = Convert.ToInt32( Console.ReadLine() );
bool validateB = ( bulan < 13 ) && ( bulan > 0 );
Console.WriteLine( $"bulan yg anda masukan {bulan}, BULAN = {validateB}" );

Console.Write("masukan tanggal : ");
int tanggal = Convert.ToInt32( Console.ReadLine() );
bool validateT = ( tanggal < 32 ) && ( tanggal > 0 );
Console.WriteLine( $"tanggal yg anda masukan {tanggal}, TANGGAL = {validateT}" ); 