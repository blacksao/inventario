using inventarui.common.entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace inventario.common.entidades
{
    public class Vale:Base
    {
        public DateTime FechahoraSolicitud { get; set; }
        public DateTime FechaEntrega { get; set; }
        public DateTime? FechaEntregaReal { get; set; }
        public List<Material> MaterialesPrestados { get; set; }
        public Empleado Solicitante { get; set; }
        public Empleado EncargadoDeAlmacen { get; set; }
    }
}
