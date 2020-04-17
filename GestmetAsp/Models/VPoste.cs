using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestmetAsp.Models
{
    public class VPoste
    {
        public int IdPoste { get; set; }
        public int RefPoste { get; set; }
        public string LibellePoste { get; set; }
        public int ChantierId { get; set; }
        public string RefChantier { get; set; }
        public string NomChantier { get; set; }
        public string LieuChantier { get; set; }
       // public VPoste() { }
    }
}