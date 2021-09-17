using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Automovil
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string  SubMarca { get; set; }
        public float NumeroMotor { get; set; }
        public  int NumeroSerie { get; set; }
        public string Color { get; set; }
    }
}
