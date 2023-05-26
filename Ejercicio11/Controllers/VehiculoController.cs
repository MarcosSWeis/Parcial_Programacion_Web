using Ejercicio11.DataAccess;
using Ejercicio11.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio11.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculoController :ControllerBase
    {
        private VehiculosContext _context;

        public VehiculoController(VehiculosContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Vehiculo>>> Get()
        {
            try
            {
                var result = await _context.Vehiculos.Include(r => r.Rueda).ToListAsync();

                return Ok(result);

            } catch (Exception ex)
            {

                throw ex;
            }

        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetById(int id)
        {
            try
            {
                var result = await _context.Vehiculos.Where(v => v.Id == id).Include(r => r.Rueda).FirstOrDefaultAsync();
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);

            } catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post(Vehiculo vehiculo)
        {
            try
            {

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var result = await _context.Vehiculos.AddAsync(vehiculo);
                await _context.SaveChangesAsync();

                return new CreatedAtRouteResult(nameof(GetById),new { id = result.Entity.Id });


            } catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Vehiculo>> Put(int id,Vehiculo vehiculo)
        {
            try
            {
                if (vehiculo.Id != id)
                {
                    return BadRequest("Los vehiculos no coinciden");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var v = await _context.Vehiculos.Where(v => v.Id == id).Include(r => r.Rueda).FirstOrDefaultAsync();

                if (v == null)
                {
                    return NotFound("No se encontro el vehiculo");
                }

                //update veshiculo
                v.Marca = vehiculo.Marca;
                v.Modelo = vehiculo.Modelo;
                v.TipoVehiculo = vehiculo.TipoVehiculo;
                v.Peso = vehiculo.Peso;
                v.FechaLanzamiento = vehiculo.FechaLanzamiento;
                v.CantidadRuedas = vehiculo.CantidadRuedas;

                //update ruada
                v.Rueda.Rodado = vehiculo.Rueda.Rodado;
                v.Rueda.PresionMaximaAire = vehiculo.Rueda.PresionMaximaAire;
                v.Rueda.AltoLlanta = vehiculo.Rueda.AltoLlanta;
                v.Rueda.AnchoLlanta = vehiculo.Rueda.AnchoLlanta;

                await _context.SaveChangesAsync();

                return Ok(v);


            } catch (Exception ex)
            {
                throw ex;
            }
        }



        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Post(int id)
        {
            try
            {
                var v = await _context.Vehiculos.Where(v => v.Id == id).FirstOrDefaultAsync();

                if (v == null)
                {
                    return NotFound("No se escontro el vehiculo");
                }
                _context.Vehiculos.Remove(v);
                await _context.SaveChangesAsync();

                return Ok();


            } catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}


