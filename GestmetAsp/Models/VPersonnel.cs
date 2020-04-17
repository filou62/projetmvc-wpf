using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestmetAsp.Models
{
    public class VPersonnel
    {
        public int Id { get; set; }
        public int Matricule { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public bool ChefEquipe { get; set; }
        //public int SocieteId { get; set; }
    }
}