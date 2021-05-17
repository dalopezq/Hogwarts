using Hogwarts.Data;
using Hogwarts.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hogwarts.Interface
{
    public class EstudianteServicio : IEstudianteServicio
    {
        private HogwartsContext _context = new HogwartsContext();


        public async Task DeleteEstudiante(int id)
        {
            var estudiantes = await _context.Estudiantes.FindAsync(id);

            if (estudiantes != null)
            {
                _context.Estudiantes.Remove(estudiantes);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Estudiante>> GetEstudiantes()
        {
            return await _context.Estudiantes.ToListAsync();
        }

        public async Task AddEstudiante(Estudiante estudiante)
        {
            _context.Estudiantes.Add(estudiante);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateEstudiante(int id, Estudiante estudiantes)
        {
            if (id == estudiantes.Id)
            {
                _context.Entry(estudiantes).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
        }
    }
}
