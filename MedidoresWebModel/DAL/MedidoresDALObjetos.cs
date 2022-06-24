using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedidoresWebModel.DTO;

namespace MedidoresWebModel.DAL
{
    public class MedidoresDALObjetos : IMedidoresDAL
    {
        private static List<Medidores> medidor = new List<Medidores>();
        
        public List<Medidores> ObtenerMedidores()
        {
            return
              new List<Medidores> 
            {
                new Medidores()
                {
                    IdMedidor = "1",
                    Tipo = "Medidor"
                },
                new Medidores()
                {
                    IdMedidor = "2",
                    Tipo = "No Medidor"
                },
                new Medidores()
                {
                   IdMedidor = "3",
                    Tipo = "Medidor"
                },
                new Medidores()
                {
                    IdMedidor = "4",
                    Tipo = "Medidor"
                },
                 new Medidores()
                {
                    IdMedidor = "5",
                    Tipo = "Medidor"
                },
                  new Medidores()
                {
                    IdMedidor = "6",
                    Tipo = "No Medidor"
                },
               
        };
        }
        public void Agregar(Medidores medidor1)
        {
        medidor.Add(medidor1);
    }
        public List<Medidores> Obtener()
        {
            return medidor;
        }
        public List<Medidores> Filtrar(string idMedidor)
        {

            return medidor.FindAll(c => c.Tipo == idMedidor);
        }
    }
}
