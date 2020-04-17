using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestmetModelsGlobal
{
    public class Poste
    {
        public int Id { get; set; }
        public int Ref { get; set; }
        public string Libelle { get; set; }
        public string UM { get; set; }
        public decimal QteUM { get; set; }
        public decimal QteHPoste { get; set; }
        public decimal QteHST { get; set; }
        public int Niveau { get; set; }
        public decimal QteHInterne { get; set; }
        public int ChantierId { get; set; }
        public bool SaisiePoste { get; set; }
        
    }
}
