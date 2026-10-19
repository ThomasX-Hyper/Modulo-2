using Escuela_Datos.Data.AccesoDatos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Escuela_Datos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]
    [EnableCors("AngularPolicy")]
    public class BackAlumnoController : ControllerBase
    {
        [HttpGet("listar")]
        public IActionResult Index()
        {
            var model = new DAAlumno();
            var datos = model.GetAlumnos();
            return Ok(datos);
        }
    

         [HttpGet("details/{id}")]

        public IActionResult Details(int id)
        {
            var model = new DAAlumno();
            var item = model.Buscar(id);

            if (item == null)

            {
                return NotFound();
            }
            return Ok(item);


        }
    }
}