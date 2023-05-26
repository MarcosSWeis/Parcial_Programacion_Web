using Ejercicio10.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Ejercicio10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculoController :ControllerBase
    {


        [HttpGet]
        public List<Vehiculo> Get()
        {
            return ListVehiculos.ListarVehiculos();
        }
    }
}
