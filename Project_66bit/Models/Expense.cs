using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_66bit.Models
{
    public class Expense
    {
        public long Id { get; set; }
        public long BillId { get; set; }
        public virtual Bill Bill { get; set; }
        public long CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public double Sum { get; set; }
        public double Paid { get; set; }
        public string Description { get; set; }
        public string Cheque { get; set; }
        public long TypeId { get; set; }
        public virtual Type Type { get; set; }
    }
}
