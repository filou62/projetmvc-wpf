using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestmetModelsClient
{
    public class VChantier:Chantier
    {
        public string VNomSociete { get; private set; }
        
        //// données retour de la Db
        public VChantier(int id, string chref, string type, string nom, int? cp, string lieu, string description, DateTime datedebut, DateTime datefin,
              decimal? heuresprevues, string zonedeplacement, string zonekm, string refdevis, bool cloture, bool archive, int societeid,string nomsociete)
            {
            Id = id;
            Ref = chref;
            Type = type;
            Nom = nom;
            CP = cp;
            Lieu = lieu;
            Description = description;
            DateDebut = datedebut;
            DateFin = datefin;
            HeuresPrevues = heuresprevues;
            ZoneDeplacement = zonedeplacement;
            ZoneKm = zonekm;
            RefDevis = refdevis;
            Cloture = cloture;
            Archive = archive;
            SocieteId = societeid;
            VNomSociete = nomsociete;

        }
    }
}
