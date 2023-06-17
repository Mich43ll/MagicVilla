using System.ComponentModel.DataAnnotations;

namespace MagicVilla_API.Models.Dto
{
    public class villaDto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Nombre { get; set; }

        public string Detalle { get; set; }

        [Required]
        public double Tarifa { get; set; }

        public int Ocupantes { get; set; }

        public int metrosCuadrados { get; set; }

        public string ImagenUlr { get; set; }

        public string Amenidad { get; set; }

    }
}
