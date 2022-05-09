using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Stokes
{
    public class DeskQuote
    {
        public Desk Desk { get; set; }
        public string CustName { get; set; }
        public int RushDays { get; set; }
        public DateTime QuoteDate { get; set; }
    }
}
