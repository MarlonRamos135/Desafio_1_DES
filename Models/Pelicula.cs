using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCPeliculas.Models
{
    public class Pelicula
    {
        public int Id { get; set; }
        [StringLength(250)]
        [Required]
        [Display(Name = "Título")]
        public string Titulo { get; set; }
        [Display(Name = "Fecha de lanzamiento")]
        [DataType(DataType.Date)]
        public DateTime FechaLanzamiento { get; set; }
        [Column(TypeName = "money")]
        [Required]
        public decimal Precio { get; set; }
        [StringLength(15)]
        [Required]
        public string Director { get; set; }
        [Required]
        public int GeneroId { get; set; } // <- Llave foranea
        [Display(Name = "Género")]
        public Genero? Genero { get; set; } // <- Propiedad de navegacion
    }
    public class Genero
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}

