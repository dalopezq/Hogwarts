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
        public readonly HogwartsContext _context;

        public EstudianteServicio(HogwartsContext context)
        {
            _context = context;
        }

        public async Task<Estudiante> DeleteEstudiante(int id)
        {
            var estudiante = await _context.Estudiantes.FindAsync(id);

            if (estudiante != null)
            {
                _context.Estudiantes.Remove(estudiante);
                await _context.SaveChangesAsync();
                return estudiante;
            }
            return estudiante;
        }

        public async Task<List<Estudiante>> GetEstudiantes()
        {
            return await _context.Estudiantes.ToListAsync();
        }

        public async Task<Estudiante> AddEstudiante(Estudiante estudiante)
        {
            var estudiantes = await _context.Estudiantes.FindAsync(estudiante.Id);

            if (estudiantes == null)
            {
                _context.Estudiantes.Add(estudiante);
                await _context.SaveChangesAsync();
                return estudiante;
            }
            return estudiante;
        }

        public async Task<Estudiante> UpdateEstudiante(int id, Estudiante estudiante)
        {
            if (id == estudiante.Id)
            {
                _context.Entry(estudiante).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return estudiante;
            }
            return estudiante;
        }
    }
}
