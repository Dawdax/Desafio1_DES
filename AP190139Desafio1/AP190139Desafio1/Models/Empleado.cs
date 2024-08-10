using System.ComponentModel.DataAnnotations;
 

namespace AP190139Desafio1.Models
{
    public class Empleado
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(250)]
        public string Apellidos { get; set; }

        [Display(Name ="Fecha de nacimiento")]
        public DateOnly FechaDeNacimiento { get; set; }

        [Required]
        [StringLength(250)]
        [Display(Name ="Dirección")]
        public string Direccion { get; set; }

        [StringLength(25)]
        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }

        [Required]
        [StringLength(250)]
        public string Cargo { get; set; }

        [Required]
        [Display(Name = "Suelo base")]
        public decimal SueldoBase { get; set; }



    }
}
