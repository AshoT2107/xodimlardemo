using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xodimlar.DataLayer;
using xodimlar.Models;

namespace xodimlar.Controllers
{
    [ApiController]
    [Route("asosiy")]
    public class HomeController : ControllerBase
    {
        private readonly XodimlarDbContext xodimlarDbContext;

        public HomeController(XodimlarDbContext _xodimlarDbContext)
        {
            xodimlarDbContext = _xodimlarDbContext;
        }

        [HttpGet("getall")]
        public IEnumerable<Xodimlar> GetAll()
        {
            return xodimlarDbContext.xodimlar;
        }
        [HttpGet]
        public string GetFirstName(int id)
        {
            Xodimlar res = xodimlarDbContext.xodimlar.FirstOrDefault(p => p.Id == id);
            return res.FirstName;
        }
    }
}
