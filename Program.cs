using System;

namespace Pertemuan_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Silahkan Pilih Printer : ");
            Console.WriteLine("1.Epson");
            Console.WriteLine("2.Canon");
            Console.WriteLine("3.LaserJet");
            Console.WriteLine("Masukan Angka Pilihan Printer Anda : "); int input = Convert.ToInt32(Console.ReadLine());

            Printer printer;

            if(input == 1)
            {
                printer = new EpsonPrinter();
            }
            else if (input == 2)
            {
                printer = new CanonPrinter();
            }
            else if (input == 3)
            {
                printer = new LaserJetPrinter();
            }
            else
            {
                Console.WriteLine("Pilihan Printer Anda Salah");
                return;
            }

            printer.DisplayDimension();
            printer.Print();
        }
    }
}
