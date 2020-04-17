using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestmetModelsGlobal
{
    public class Personnel
    {
        public int Id { get; set; }
        public int Matricule { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public DateTime? DateNaissance { get; set; }
        public string Qualification { get; set; }
        public bool ChefEquipe { get; set; }
        public int SocieteId { get; set; }
    }
}
