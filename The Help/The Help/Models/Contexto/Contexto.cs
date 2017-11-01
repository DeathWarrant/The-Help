using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace The_Help.Models.Contexto
{
    public class Contexto : DbContext
    {
        public Contexto() : base("strConn")
        {

        }

        public System.Data.Entity.DbSet<The_Help.Models.Modelo3D> Modelo3D { get; set; }

        public System.Data.Entity.DbSet<The_Help.Models.TipoModelo3D> TipoModelo3D { get; set; }
    }
}