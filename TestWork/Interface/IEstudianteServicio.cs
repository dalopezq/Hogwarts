using Hogwarts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hogwarts.Interface
{
    public interface IEstudianteServicio
    {
        Task<List<Estudiante>> GetEstudiantes();
        Task<Estudiante> DeleteEstudiante(int id);
        Task<Estudiante> AddEstudiante(Estudiante estudiante);
        Task<Estudiante> UpdateEstudiante(int id, Estudiante estudiante);
    }
}
