using CESistemaVenta.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CESistemaVenta.Negocio
{
    public class NPaisProcedencia:Contexto 
    {
        CasoEstudioSistemaVentasEntities Esquema;

        public NPaisProcedencia()
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
        public Boolean InsertarPaisProcedencia(PaisProcedencia ObjPaisProcedencia)
        {
            Esquema.PaisProcedencia.Add(ObjPaisProcedencia);
            return Esquema.SaveChanges() == 1;
        }
        public List<PaisProcedencia> TraerPaisProcedencia(int id)
        {
            if (id == 0)
            {
                return (from e in Esquema.PaisProcedencia select e).ToList();
            }
            else
            {
                return (from e in Esquema.PaisProcedencia where e.Id.Equals(id) select e).ToList();
            }
        }
        public List<PaisProcedencia> TraerPaisProcedenciaPorNombre(string NombrePais)
        {
            return (from e in Esquema.PaisProcedencia where e.NombrePais.ToUpper().StartsWith(NombrePais.ToUpper()) select e).ToList();
        }
    }
}
