using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Infraestructura.Datos;
using Core.entidiades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LugaresController : Controller
    {
        private  ApplicationDbContext _DbContext { get; }
        public LugaresController(ApplicationDbContext dbContext )
        {
            _DbContext = dbContext;

        }

        [HttpGet]
        public async Task< ActionResult<List<Lugar>> > getLugares()
        {
           var lugares= await _DbContext.Lugar.ToListAsync();
           return Ok(lugares);

        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Lugar>> getLugar(int id)
        {
            return await _DbContext.Lugar.FindAsync(id);
        }
    }
}