using CESistemaVenta.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CESistemaVenta.Negocio
{
    public class NAlmacen:Contexto 
    {
        CasoEstudioSistemaVentasEntities Esquema;

        public NAlmacen()
        {
            Esquema =this.TraeEsquema();
        }
        public int GenerarId()
        {
            try
            {
                return (from e in Esquema.Almacen select e.Id).Max() + 1;
            }
            catch (Exception ex)
            {
                return 1;
            }
            
        }
        public Boolean InsertarAlmacen(Almacen ObjAlmacen)
        {
            Esquema.Almacen.Add(ObjAlmacen);
            return Esquema.SaveChanges() == 1;
        }
        public List<Almacen> TraerAlmacen(int id)
        {
            if (id == 0)
            {
                return (from e in Esquema.Almacen select e).ToList();
            }
            else
            {
                return (from e in Esquema.Almacen where e.Id.Equals(id) select e).ToList();
            }
        }
        public List<Almacen> TraerAlmacenPorNombre(string NombreAlmacen)
        {
            return (from e in Esquema.Almacen where e.Almacen1.ToUpper().StartsWith(NombreAlmacen.ToUpper()) select e).ToList();
        }
    }
}
