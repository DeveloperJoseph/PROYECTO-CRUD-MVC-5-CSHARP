﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CHSARP_MVC_WEB.MODELO
{
    public class MUsuario
    {
        public int idUsuario { get; set; }
        public int idPrivilegio { get; set; }
        public String Name_usuario { get; set; }
        public String Email_Usuario { get; set; }
        public String Password_Usuario { get; set; }
    }
}