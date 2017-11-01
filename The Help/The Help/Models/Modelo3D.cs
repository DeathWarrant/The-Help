using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace The_Help.Models
{
    public class Modelo3D
    {
        public int Modelo3DID { get; set; }
        public string Nome { get; set; }
        public string Historia { get; set; }
        public int Idade { get; set; }
        public float Altura { get; set; }
        public float Peso { get; set; }

        public int TipoModelo3DID { get; set; }
        public TipoModelo3D _TipoModelo3D { get; set; }
    }
}