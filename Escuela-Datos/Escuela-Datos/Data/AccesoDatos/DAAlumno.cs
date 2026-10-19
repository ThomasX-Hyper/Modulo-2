using Escuela_Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Escuela_Datos.Data.AccesoDatos
{
    public class DAAlumno
    {

        public IEnumerable<Alumno> GetAlumnos()
        {
            var lista = new List<Alumno>();
            using (var model=new ApplicationDbContext())
            {
                lista = model.Alumno.Include(item => item.Escuela).ToList();
            }
            return lista;
        }

        public Alumno? Buscar(int id )
        {
            using (var model=new ApplicationDbContext())
            {
                var dato = model.Alumno.Include(item => item.Escuela).FirstOrDefault(i => i.IdAlumno == id);
                return dato;
            }

        }

        public int Insert(Alumno dato){
            var res = 0;
            using (var model=new ApplicationDbContext())
            {
                model.Add(dato);
                model.SaveChanges();
                res = dato.IdAlumno;
            }
            return res;
        }

        public bool Actualizar(Alumno dato)
        {
            using (var model=new ApplicationDbContext())
            {
                var res = model.Alumno.FirstOrDefault(f => f.IdAlumno == dato.IdAlumno);
                if (res==null)
                {
                    return false;
                }
                res.IdEscuela = dato.IdEscuela;
                res.NombreA = dato.NombreA;
                res.Correo = dato.Correo;
                res.Apellido = dato.Apellido;
                model.SaveChanges();
                return true;
            }

        }

        public bool Eliminar(int id )
        {
            using (var model=new ApplicationDbContext())
            {
                var dato = model.Alumno.FirstOrDefault(d=>d.IdAlumno==id);
                if (dato==null)
                {
                    return false;

                }
                model.Alumno.Remove(dato);
                model.SaveChanges();
                return true;
            }
        }

    }
}
