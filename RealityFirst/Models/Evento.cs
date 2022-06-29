using System;
using System.ComponentModel.DataAnnotations;

namespace RealityFirst.Models
{
    public class Evento
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Foto")]
        public string fotoURL { get; set; }

        [Required]
        [StringLength(500)]
        public string Descripcion { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(100)]
        public string Lugar { get; set; }

        [Required]
        [StringLength(100)]
        public string Artista { get; set; }

    }
}
