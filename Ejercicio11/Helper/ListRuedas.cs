using Ejercicio11.Models;
using System.Collections.Generic;

namespace Ejercicio11.Helper
{
    public static class ListRuedas
    {

        public static List<Rueda> Listar()
        {
            List<Rueda> _ruedas = new List<Rueda>();

            _ruedas.Add(new Rueda
            {
                Id = 1,
                Rodado = 20,
                PresionMaximaAire = 35,
                AltoLlanta = 55,
                AnchoLlanta = 245
            });
            _ruedas.Add(new Rueda
            {
                Id = 2,
                Rodado = 17,
                PresionMaximaAire = 32,
                AltoLlanta = 50,
                AnchoLlanta = 215
            });

            _ruedas.Add(new Rueda
            {
                Id = 3,
                Rodado = 18,
                PresionMaximaAire = 35,
                AltoLlanta = 60,
                AnchoLlanta = 265
            });

            _ruedas.Add(new Rueda
            {
                Id = 4,
                Rodado = 19,
                PresionMaximaAire = 34,
                AltoLlanta = 55,
                AnchoLlanta = 235
            });

            _ruedas.Add(new Rueda
            {
                Id = 5,
                Rodado = 20,
                PresionMaximaAire = 36,
                AltoLlanta = 50,
                AnchoLlanta = 245
            });

            _ruedas.Add(new Rueda
            {
                Id = 6,
                Rodado = 16,
                PresionMaximaAire = 32,
                AltoLlanta = 50,
                AnchoLlanta = 205
            });

            _ruedas.Add(new Rueda
            {
                Id = 7,
                Rodado = 17,
                PresionMaximaAire = 35,
                AltoLlanta = 55,
                AnchoLlanta = 265
            });

            _ruedas.Add(new Rueda
            {
                Id = 8,
                Rodado = 18,
                PresionMaximaAire = 34,
                AltoLlanta = 55,
                AnchoLlanta = 235
            });

            _ruedas.Add(new Rueda
            {
                Id = 9,
                Rodado = 17,
                PresionMaximaAire = 32,
                AltoLlanta = 50,
                AnchoLlanta = 215
            });

            _ruedas.Add(new Rueda
            {
                Id = 10,
                Rodado = 18,
                PresionMaximaAire = 35,
                AltoLlanta = 60,
                AnchoLlanta = 265
            });
            return _ruedas;
        }



    }
}
