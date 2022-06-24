using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresWebModel.DTO
{
    public class Medidores
    {
        private string idMedidor;
        private string tipo;

        public string IdMedidor { get => idMedidor; set => idMedidor = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
