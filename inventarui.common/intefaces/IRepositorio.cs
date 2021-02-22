using inventario.common.entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace inventario.common.intefaces
{
    public interface IRepositorio<T> where T:Base
    {
        bool Create(T entidad);
        bool Update(string Id, T entidadModificada);
        bool Delete(T entidad);
        List<T> Read { get; }
    }
}
