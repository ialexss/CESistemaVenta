using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CESistemaVenta.Datos
{
    public class Contexto
    {
        public CasoEstudioSistemaVentasEntities TraeEsquema()
        {
            CasoEstudioSistemaVentasEntities Esq = new CasoEstudioSistemaVentasEntities();
            return Esq;
        }
    }
}
