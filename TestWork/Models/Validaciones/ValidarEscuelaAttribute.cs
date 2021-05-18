using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hogwarts.Models.Validaciones
{
    public class ValidarEscuelaAttribute : ValidationAttribute
    {
        /// <summary>
        /// Validar escuelas de Hogwarts
        /// </summary>
        /// <param name="value"></param>
        /// <param name="validationContext"></param>
        /// <returns></returns>
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            List<string> Hogwarts = new List<string>()
            {
                "Gryffindor",
                "Hufflepuff",
                "Ravenclaw",
                "Slytherin"
            };

            foreach (string School in Hogwarts)
            {
                if (School == value.ToString()) //Checks if str list has the current value.
                {
                    return ValidationResult.Success;
                }     
            }
            return new ValidationResult("La escuela no se encuentra en la lista actual");
        }
    }
}
