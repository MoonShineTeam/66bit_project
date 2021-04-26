using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Project_66bit.Interfaces;
using Project_66bit.Models;

namespace Project_66bit.Controllers
{
    public class BillController : ControllerBase
    {
        private readonly IBills _repo;
        public BillController(IBills bills)
        {
            _repo = bills;
        }

        public IEnumerable<Bill> All() => _repo.AllBills;

        public Bill Id(long id) => _repo.GetBillById(id);

        public Bill UserId(long id) => _repo.GetBillByUserId(id);
    }
}