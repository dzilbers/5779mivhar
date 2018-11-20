using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    public class MyPrinter
    {
        public class PrinterArgs : EventArgs
        {
            public readonly int pages; // how many pages are missing
            public PrinterArgs(int pages)
            {
                this.pages = pages;
            }
        }

        public event EventHandler<PrinterArgs> PageOver = null;
        private int pageCount = 20;

        private void handlePageOver(int pages)
        {
            if (PageOver != null)
                //PageOver(this, EventArgs.Empty);
                PageOver(this, new PrinterArgs(pages));
        }

        public void Print(int pages)
        {
            if (pages <= pageCount)
                pageCount -= pages;
            else
            {
                int temp = pageCount;
                pageCount = 0;
                handlePageOver(pages - temp);
            }
        }
    }
}
