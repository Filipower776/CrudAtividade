using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_atividade.Models
{
    public class Heroi
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Titulo { get; set; }
        public string Mov { get; set; }
        public string TipoCor { get; set; }
        public int Pv { get; set; }
        public int Atk { get; set; }
        public int Vel { get; set; }
        public int Def { get; set; }
        public int Res { get; set; }
    }
}