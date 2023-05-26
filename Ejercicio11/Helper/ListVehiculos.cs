using Ejercicio11.Models;
using System;
using System.Collections.Generic;

namespace Ejercicio11.Helper
{
    public static class ListVehiculos
    {
        public static List<Vehiculo> ListarVehiculos()
        {
            List<Vehiculo> listaVehiculos = new List<Vehiculo>();

            listaVehiculos.Add(new Vehiculo
            {
                Id = 1,
                Marca = "Ford",
                Modelo = "Mustang",
                TipoVehiculo = TipoVehiculo.Deportivo,
                Peso = 1500,
                FechaLanzamiento = new DateTime(2020,1,1),

                RuedaId = 1
            });

            listaVehiculos.Add(new Vehiculo
            {
                Id = 2,
                Marca = "Toyota",
                Modelo = "Corolla",
                TipoVehiculo = TipoVehiculo.Sedan,
                Peso = 1300,
                FechaLanzamiento = new DateTime(2019,5,1),

                RuedaId = 2
            });

            listaVehiculos.Add(new Vehiculo
            {
                Id = 3,
                Marca = "Chevrolet",
                Modelo = "Silverado",
                TipoVehiculo = TipoVehiculo.PikUp,
                Peso = 2000,
                FechaLanzamiento = new DateTime(2018,10,1),

                RuedaId = 3
            });

            listaVehiculos.Add(new Vehiculo
            {
                Id = 4,
                Marca = "Honda",
                Modelo = "CR-V",
                TipoVehiculo = TipoVehiculo.Suv,
                Peso = 1600,
                FechaLanzamiento = new DateTime(2021,3,1),

                RuedaId = 4
            });

            listaVehiculos.Add(new Vehiculo
            {
                Id = 5,
                Marca = "BMW",
                Modelo = "i8",
                TipoVehiculo = TipoVehiculo.Deportivo,
                Peso = 1700,
                FechaLanzamiento = new DateTime(2022,2,1),

                RuedaId = 5

            });

            listaVehiculos.Add(new Vehiculo
            {
                Id = 6,
                Marca = "Nissan",
                Modelo = "Sentra",
                TipoVehiculo = TipoVehiculo.Sedan,
                Peso = 1400,
                FechaLanzamiento = new DateTime(2019,7,1),

                RuedaId = 6
            });

            listaVehiculos.Add(new Vehiculo
            {
                Id = 7,
                Marca = "Ford",
                Modelo = "Ranger",
                TipoVehiculo = TipoVehiculo.PikUp,
                Peso = 1800,
                FechaLanzamiento = new DateTime(2017,9,1),

                RuedaId = 7
            });

            listaVehiculos.Add(new Vehiculo
            {
                Id = 8,
                Marca = "Toyota",
                Modelo = "RAV4",
                TipoVehiculo = TipoVehiculo.Suv,
                Peso = 1500,
                FechaLanzamiento = new DateTime(2020,5,1),

                RuedaId = 8
            });

            listaVehiculos.Add(new Vehiculo
            {
                Id = 9,
                Marca = "Chevrolet",
                Modelo = "Cruze",
                TipoVehiculo = TipoVehiculo.Sedan,
                Peso = 1300,
                FechaLanzamiento = new DateTime(2019,2,1),

                RuedaId = 9
            });

            listaVehiculos.Add(new Vehiculo
            {
                Id = 10,
                Marca = "Jeep",
                Modelo = "Wrangler",
                TipoVehiculo = TipoVehiculo.Suv,
                Peso = 1900,
                FechaLanzamiento = new DateTime(2021,8,1),

                RuedaId = 10
            });
            return listaVehiculos;
        }


    }
}
