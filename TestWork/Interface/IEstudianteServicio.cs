using Hogwarts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hogwarts.Interface
{
    public interface IEstudianteServicio
    {
        Task<IEnumerable<Estudiante>> GetEstudiantes();
        Task DeleteEstudiante(int id);
        Task AddEstudiante(Estudiante estudiante);
        Task UpdateEstudiante(int id, Estudiante estudiantes);
    }
}
