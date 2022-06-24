using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedidoresWebModel.DTO;

namespace MedidoresWebModel.DAL
{
    public class ConsumoMedidoresDALObjetos : IConsumoMedidoresDAL
    {
        private static List<Lectura> lecturas = new List<Lectura>();
        public void Agregar(Lectura lectura)
        {
            lecturas.Add(lectura);
        }

        public List<Lectura> Obtener()
        {
            return lecturas;
        }

        public void Eliminar(string idMedidor)
        {
            Lectura eliminando = lecturas.Find(c => c.IdMedidor == idMedidor);
            lecturas.Remove(eliminando);
        }

        public List<Lectura> Filtrar(string idMedidor)
        {
            return lecturas.FindAll(c => c.IdMedidor == idMedidor);
        }
    }
}
