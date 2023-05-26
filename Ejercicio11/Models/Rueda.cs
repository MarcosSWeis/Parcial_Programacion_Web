using System.ComponentModel.DataAnnotations;

namespace Ejercicio11.Models
{
    public class Rueda
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public short Rodado { get; set; }
        [Required]
        public int PresionMaximaAire { get; set; }
        [Required]
        public short AltoLlanta { get; set; }
        [Required]
        public short AnchoLlanta { get; set; }
    }

}
