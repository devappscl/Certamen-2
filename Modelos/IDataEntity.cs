using Datos;
using System.Collections.Generic;

namespace Modelos
{
    public interface IDataEntity
    {
        data Data { get; set; }
        List<Parametros> parametros { get; set; }
    }
}
