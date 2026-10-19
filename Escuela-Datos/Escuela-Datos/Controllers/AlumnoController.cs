using Escuela_Datos.Data.AccesoDatos;
using Escuela_Datos.Models;
using Microsoft.AspNetCore.Mvc;

namespace Escuela_Datos.Controllers
{
    public class AlumnoController : Controller
    {
        private readonly DAAlumno obj = new DAAlumno();
        public IActionResult Index()
        {
            ViewBag.Alum = obj.GetAlumnos();

            return View();
        }

        public IActionResult Create()
        {
            ViewBag.Alum = obj.GetAlumnos();

            return View(new Alumno());
        }
        [HttpPost]
        public IActionResult Create(Alumno dato)
        {
            dato.IdAlumno = 0;
            var model = obj.Insert(dato);
            ViewBag.Alum = obj.GetAlumnos();

            return View(dato);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id )
        {
            var alu = obj.Buscar(id);
            ViewBag.Alum = obj.GetAlumnos();
            return View(alu);
        }

        [HttpPost]
        public IActionResult Edit(int id,Alumno alu)
        {

            if (id != alu.IdAlumno) return BadRequest();

            if (!ModelState.IsValid)
            {
                ViewBag.Alum = obj.GetAlumnos();
                return View(alu);
            }

            if (!obj.Actualizar(alu)) return NotFound();

            TempData["Ok"] = "Alumno actualizado";
            return RedirectToAction(nameof(Index));

        }

        public IActionResult Delete(int id )
        {
            var dato = obj.Buscar(id);
            return View(dato);
        }

        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var dato = obj.Eliminar(id);
            TempData["Ok"] = "Registro Eliminado";
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var dato = obj.Buscar(id);
            return View(dato);
        }
    }
}
