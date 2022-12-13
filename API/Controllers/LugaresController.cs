using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LugaresController : Controller
    {
        [HttpGet]
        public string getLugares()
        {
            return "Esta sera una lista de lugares";

        }

        [HttpGet("{id}")]

        public string getLugar(int id)
        {
            return "Retornara un solo lugar"; 
        }
    }
}