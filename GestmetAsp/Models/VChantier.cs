using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestmetAsp.Models
{
    public class VChantier
    {
        public int Id { get; set; }
        public string Ref { get; set; }
        public string Nom { get; set; }
        public string Lieu { get; set; }
        public string VNomSociete { get; set; }

    }
}