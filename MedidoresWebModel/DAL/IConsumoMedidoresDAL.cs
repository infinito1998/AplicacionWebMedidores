using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedidoresWebModel.DTO;

namespace MedidoresWebModel.DAL
{
    public interface IConsumoMedidoresDAL
    {
        List<Lectura> Obtener();
        void Agregar(Lectura lectura);
        void Eliminar(string idMedidor);

        List<Lectura> Filtrar(string idMedidor);
    }
}
