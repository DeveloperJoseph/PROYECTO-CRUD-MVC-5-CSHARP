using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHSARP_MVC_WEB.MODELO
{
    public class Mascota
    {
        //propiedades de get and set de mi objeto Mascota
        public int id_mascota { get; set; }
        public String nomb_mascota { get; set; }
        public Decimal peso_kg_mascota { get; set; }
        public int id_raza { get; set; }
        public int id_tipo_ali { get; set; }
    }
}