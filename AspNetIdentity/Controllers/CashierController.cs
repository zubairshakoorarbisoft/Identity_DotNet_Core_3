using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AspNetIdentity.Controllers
{
    [Authorize(Roles = "Admin,Cashier")]
    public class CashierController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}