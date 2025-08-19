﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.DTOs
{
    public class RegistroUsuarioDTO
    {    
       
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public int Edad { get; set; } 
        public string Cedula { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;  
        public string Contraseña { get; set; } = string.Empty;
        public string Sexo { get; set; } = string.Empty;
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Año { get; set; }
         
      
    }
}
