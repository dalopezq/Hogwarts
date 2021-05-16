using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hogwarts.Data;
using Hogwarts.Models;

namespace Hogwarts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteController : ControllerBase
    {
        private readonly HogwartsContext _context;

        public EstudianteController(HogwartsContext context)
        {
            _context = context;
        }

        // GET: api/Estudiantes
        /// <summary>
        /// Consultar todas las solicitudes enviadas
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Estudiante>>> GetEstudiantes()
        {
            return await _context.Estudiantes.ToListAsync();
        }

        // PUT: api/Estudiantes/5
        /// <summary>
        /// Actualizar solicitud de Ingreso
        /// </summary>
        /// <param name="id"></param>
        /// <param name="estudiantes"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstudiantes(int id, Estudiante estudiantes)
        {
            if (id != estudiantes.Id)
            {
                return BadRequest();
            }

            _context.Entry(estudiantes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstudiantesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Estudiantes
        /// <summary>
        /// Enviar Solicitud de Ingreso
        /// </summary>
        /// <param name="estudiantes"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<Estudiante>> PostEstudiantes(Estudiante estudiantes)
        {
            _context.Estudiantes.Add(estudiantes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEstudiantes", new { id = estudiantes.Id }, estudiantes);
        }

        // DELETE: api/Estudiantes/5
        /// <summary>
        /// Eliminar la solicitud de ingreso
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<ActionResult<Estudiante>> DeleteEstudiantes(int id)
        {
            var estudiantes = await _context.Estudiantes.FindAsync(id);
            if (estudiantes == null)
            {
                return NotFound();
            }

            _context.Estudiantes.Remove(estudiantes);
            await _context.SaveChangesAsync();

            return estudiantes;
        }

        private bool EstudiantesExists(int id)
        {
            return _context.Estudiantes.Any(e => e.Id == id);
        }
    }
}
