using System.ComponentModel.DataAnnotations;

namespace Tarea_2.Models
{
    public class libro
    {
        [Key]
        public int Id { get; set; }
        [StringLength(60)]
        public string Titulo { get; set; }
        [StringLength(60)]

        public string Autor { get; set; }
        [StringLength(40)]

        public string Genero { get; set; }
        [StringLength(40)]

        public string Disponibilidad { get; set; }

    }
}
