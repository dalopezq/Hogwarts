using Hogwarts.Models.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hogwarts.Models
{
    public class Estudiante
    {
        public int Id { get; set; }

        [StringLength(20, ErrorMessage = "Longitud maxima de 20 caracteres")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Solo se permiten letras")]
        public string Nombre { get; set; }

        [StringLength(20, ErrorMessage = "Longitud maxima de 20 caracteres")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Solo se permiten letras")]
        public string Apellido { get; set; }

        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [StringLength(10, ErrorMessage = "Longitud maxima de 10 caracteres numericos")]
        public string Identificacion { get; set; }

        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [StringLength(2, ErrorMessage = "Longitud maxima de 2 caracteres numericos")]
        public string Edad { get; set; }

        [ValidarEscuela(ErrorMessage = "La escuela no se encuentra en la lista actual")]
        public string Escuela { get; set; }
    }
}
