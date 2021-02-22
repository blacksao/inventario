using inventario.common.entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace inventarui.common.entidades
{
    public class Empleado:Base 
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Area { get; set; }
        
    }
}
