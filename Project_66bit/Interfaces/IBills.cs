using System.Collections.Generic;
using Project_66bit.Models;

namespace Project_66bit.Interfaces
{
    public interface IBills
    {
        IEnumerable<Bill> AllBills { get; }
        Bill GetBillById(long id);
        Bill GetBillByUserId(long userId);
    }
}