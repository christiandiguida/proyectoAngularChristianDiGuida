using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using API.Data;
using API.DTOs;
using API.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlojamientosController : ControllerBase
    {
        private readonly DataContext _context;

        public AlojamientosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Alojamiento>>> getAlojamientos()
        {
            return await _context.Alojamiento.ToListAsync();

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Alojamiento>> getAlojamiento(int id)
        {
            return await _context.Alojamiento.FindAsync(id);

        }
        [HttpPut]
        public async Task<ActionResult> updateAlojamiento(AlojamientoUpdateDTO alojamiento)
        {
            // var user = new Alojamiento();

            var user = await _context.Alojamiento.FindAsync(alojamiento.id);
            user.Id = alojamiento.id;
            user.codAlojamiento = alojamiento.codAlojamiento;
            user.alojamiento = alojamiento.alojamiento;
            user.direccion = alojamiento.direccion;
            user.observaciones = alojamiento.observaciones;

            _context.Alojamiento.Update(user);
            _context.SaveChanges();
            return NoContent();


        }
    }
}
