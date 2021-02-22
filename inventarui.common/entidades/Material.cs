using inventario.common.entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace inventarui.common.entidades
{
    public class Material:Base
    { 
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        
    }
}
