using Ejercicio11.Helper;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Ejercicio11.Models
{
    public enum TipoVehiculo
    {
        [Description("Deportivo")]
        Deportivo = 0,
        [Description("Sedan")]
        Sedan,
        [Description("PikUp")]
        PikUp,
        [Description("Suv")]
        Suv,
        [Description("Coope")]
        Coope
    }
    public class Vehiculo
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(15)]
        public string Marca { get; set; }
        [Required, MaxLength(20)]
        public string Modelo { get; set; }
        [Required, Range(0,4)]
        public TipoVehiculo TipoVehiculo { get; set; }
        [Required, Range(50,5000)]
        public int Peso { get; set; }
        [Required]
        public DateTime FechaLanzamiento { get; set; }
        [Required, Range(4,6)]
        public int CantidadRuedas { get; set; }
        //ese caso solo aplica que todas las ruedas sean iguales ese decir solo indico que caracteristicas tiene la rauda de este auto y asi seran las otras
        [Required]
        public int RuedaId { get; set; }
        [ForeignKey("RuedaId")]
        public Rueda Rueda { get; set; }
        public string TipoVehiculoString => Enum.GetValues(typeof(TipoVehiculo))
                                                .OfType<TipoVehiculo>()
                                                .Where(x => x == TipoVehiculo)
                                                .Select(x => x.GetDescription())
                                                .FirstOrDefault();
    }
}
