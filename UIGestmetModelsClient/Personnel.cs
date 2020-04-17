using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIGestmetModelsClient
{
        public class Personnel
        {
            public int Id { get; private set; }
            public int Matricule { get; private set; }
            public string Prenom { get; private set; }
            public string Nom { get; private set; }
            public DateTime? DateNaissance { get; private set; }
            public string Qualification { get; private set; }
            public bool ChefEquipe { get; private set; }
            public int SocieteId { get; private set; }
            public Personnel(int matricule, string prenom, string nom, DateTime? datenaissance,
                string qualification, bool chefequipe, int societeid)
            {

                Matricule = matricule;
                Prenom = prenom;
                Nom = nom;
                DateNaissance = datenaissance;
                Qualification = qualification;
                ChefEquipe = chefequipe;
                SocieteId = societeid;
            }
            // données retour de la Db
            public Personnel(int personnelid, int matricule, string prenom, string nom, DateTime? datenaissance,
                string qualification, bool chefequipe, int societeid)
                : this(matricule, prenom, nom, datenaissance, qualification, chefequipe, societeid)
            {
                Id = personnelid;
            }
        }
    
}

