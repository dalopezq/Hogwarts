using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hogwarts.Data;
using Hogwarts.Models;
using Hogwarts.Interface;

namespace Hogwarts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteController : ControllerBase
    {
        public readonly IEstudianteServicio _context;

        public EstudianteController(IEstudianteServicio context)
        {
            _context = context;
        }

        // GET: api/Estudiantes
        /// <summary>
        /// Consultar todas las solicitudes enviadas
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<Estudiante>> GetEstudiantes()
        {
            return await _context.GetEstudiantes();
        }

        // PUT: api/Estudiantes/5
        /// <summary>
        /// Actualizar solicitud de Ingreso
        /// </summary>
        /// <param name="id"></param>
        /// <param name="estudiantes"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task PutEstudiantes(int id, Estudiante estudiantes)
        {
            await _context.UpdateEstudiante(id, estudiantes);
        }

        // POST: api/Estudiantes
        /// <summary>
        /// Enviar Solicitud de Ingreso
        /// </summary>
        /// <param name="estudiantes"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task PostEstudiantes(Estudiante estudiantes)
        {
            await _context.AddEstudiante(estudiantes);
        }

        // DELETE: api/Estudiantes/5
        /// <summary>
        /// Eliminar la solicitud de ingreso
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _context.DeleteEstudiante(id);
        }
    }
}
