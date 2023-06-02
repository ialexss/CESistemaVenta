using CESistemaVenta.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CESistemaVenta.Negocio
{
    public class NMarca:Contexto 
    {
        CasoEstudioSistemaVentasEntities Esquema;

        public NMarca()
        {
            Esquema =this.TraeEsquema();
        }
        public int GenerarId()
        {
            try
            {
                return (from e in Esquema.PaisProcedencia select e.Id).Max() + 1;
            }
            catch (Exception ex)
            {
                return 1;
            }
            
        }
        public Boolean InsertarPaisProcedencia(Marca ObjMarca)
        {
            Esquema.Marca.Add(ObjMarca);
            return Esquema.SaveChanges() == 1;
        }
        public List<Marca> TraerMarca(int id)
        {
            if (id == 0)
            {
                return (from e in Esquema.Marca select e).ToList();
            }
            else
            {
                return (from e in Esquema.Marca where e.Id.Equals(id) select e).ToList();
            }
        }
        public List<Marca> TraerMarcaPorNombre(string NombreMarca)
        {
            return (from e in Esquema.Marca where e.NombreMarca.ToUpper().StartsWith(NombreMarca.ToUpper()) select e).ToList();
        }
    }
}
