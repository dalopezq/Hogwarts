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
        [Required(ErrorMessage = "Campo Obligatorio")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(20, ErrorMessage = "Longitud maxima de 20 caracteres")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Solo se permiten letras")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(20, ErrorMessage = "Longitud maxima de 20 caracteres")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Solo se permiten letras")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [StringLength(10, ErrorMessage = "Longitud maxima de 10 caracteres numericos")]
        public string Identificacion { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [StringLength(2, ErrorMessage = "Longitud maxima de 2 caracteres numericos")]
        public string Edad { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [ValidarEscuela]
        public string Escuela { get; set; }
    }
}
