using System;

namespace Ejercicio10.Service
{
    public enum TipoVehiculo { Deportivo, Sedan, PikUp, Suv, Coope }
    public class Vehiculo
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public TipoVehiculo TipoVehiculo { get; set; }
        public int Peso { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        public short CantidadRuedas { get; set; }
        public Rueda Rueda { get; set; }
    }
}
