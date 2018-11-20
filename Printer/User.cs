using System;

namespace Printer
{
    class User
    {
        private MyPrinter myPrinter;
        private string name;

        public User(string name, MyPrinter printer)
        {
            this.name = name;
            myPrinter = printer;
            printer.PageOver += myPageOver;
        }

        private void myPageOver(object printer, MyPrinter.PrinterArgs args)
        {
            if (printer == myPrinter)
            {
                Console.WriteLine("{0}: {1} pages missing!", name, args.pages);
            }
        }
    }
}
