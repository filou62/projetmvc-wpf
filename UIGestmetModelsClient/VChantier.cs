using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIGestmetModelsClient
{
    public class VChantier
    {
        public int Id { get; private set; }
        public string Ref { get; private set; }
        public string Nom { get; private set; }
        public string Lieu { get; private set; }
        public string VNomSociete { get; private set; }

        public VChantier(int id, string chref, string nom, string lieu, string nomsociete)
        {
            Id = id;
            Ref = chref;
            Nom = nom;
            Lieu = lieu;
            VNomSociete = nomsociete;

        }
    }
}
