using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIGestmetModelsClient
{
    public class VPoste
    {
        public int IdPoste { get; private set; }
        public int RefPoste { get; private set; }
        public string LibellePoste { get; private set; }
        public int ChantierId { get; private set; }
        public string RefChantier { get; private set; }
        public string NomChantier { get; private set; }
        public string LieuChantier { get; private set; }
        public VPoste(int idposte, int refposte, string libelleposte, int chantierid, string refchantier, string nomchantier, string lieuchantier)
        {
            IdPoste = idposte;
            RefPoste = refposte;
            LibellePoste = libelleposte;
            ChantierId = chantierid;
            RefChantier = refchantier;
            NomChantier = nomchantier;
            LieuChantier = lieuchantier;
        }
    }
}
