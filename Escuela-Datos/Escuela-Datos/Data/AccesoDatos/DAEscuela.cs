using Escuela_Datos.Models;
using Microsoft.EntityFrameworkCore;

namespace Escuela_Datos.Data.AccesoDatos
{
    public class DAEscuela
    {

        public IEnumerable<Escuela> GetEscuelas()
        {
            var lista = new List<Escuela>();
            using (var model=new ApplicationDbContext())
            {
                lista = model.Escuela.ToList();
            }
            return lista;
        }
    }
}
