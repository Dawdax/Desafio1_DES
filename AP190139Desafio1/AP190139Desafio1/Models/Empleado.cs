using System.ComponentModel.DataAnnotations;
 

namespace AP190139Desafio1.Models
{
    public class Empleado
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo de nombres es requerido")]
        [StringLength(250)]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "El campo de apellidos es requerido")]
        [StringLength(250)]
        public string Apellidos { get; set; }

        [Display(Name ="Fecha de nacimiento")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "El campo de fecha de nacimiento es requerido")]
        public DateOnly FechaDeNacimiento { get; set; }

        [Required(ErrorMessage = "El campo de dirección es requerido")]
        [StringLength(250)]
        [Display(Name ="Dirección")]
        public string Direccion { get; set; }

        [StringLength(25)]
        [Required(ErrorMessage = "El campo de Teléfono es requerido")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El campo de Cargo es requerido")]
        [StringLength(250)]
        public string Cargo { get; set; }

        [Required(ErrorMessage = "El campo de sueldo base es requerido")]
        [Range(365,2500)]
        [DataType(DataType.Currency)]
        [Display(Name = "Suelo base")]
        public decimal SueldoBase { get; set; }



    }
}
