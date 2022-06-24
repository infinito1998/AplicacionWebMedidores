using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedidoresWebModel.DTO;

namespace MedidoresWebModel.DAL
{
    public interface IMedidoresDAL
    {
        List<Medidores> ObtenerMedidores();
        void Agregar(Medidores medidor);
        List<Medidores> Obtener();
        List<Medidores> Filtrar(string idMedidor);
    }
}
