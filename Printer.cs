using System;
using System.Collections.Generic;
using System.Text;

namespace Pertemuan_9
{
    class Printer
    {
        public virtual void DisplayDimension()
        {
            Console.WriteLine("Default display dimension");
        }

        public virtual void Print()
        {
            Console.WriteLine("Default Printing");
        }
    }

    class EpsonPrinter : Printer
    {
        public override void DisplayDimension()
        {
            Console.WriteLine("Epson display dimension : 10*11");
        }

        public override void Print()
        {
            Console.WriteLine("Epson printer printing ...");
        }
    }

    class CanonPrinter : Printer
    {
        public override void DisplayDimension()
        {
            Console.WriteLine("Canon display dimension : 9.5*12");
        }

        public override void Print()
        {
            Console.WriteLine("Canon printer printing ...");
        }
    }

    class LaserJetPrinter : Printer
    {
        public override void DisplayDimension()
        {
            Console.WriteLine("LaserJet display dimension : 12*12");
        }

        public override void Print()
        {
            Console.WriteLine("LaserJet printer printing ...");
        }
    }
}
