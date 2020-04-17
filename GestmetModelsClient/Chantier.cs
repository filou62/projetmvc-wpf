using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestmetModelsClient
{
    public class Chantier
    {
        public int Id { get; set; }
        public string Ref { get;  set; }
        public string Type { get; set; }
        public string Nom { get; set; }
        public int? CP { get; set; }
        public string Lieu { get; set; }
        public string Description { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public decimal? HeuresPrevues { get; set; }
        public string ZoneDeplacement { get; set; }
        public string ZoneKm { get; set; }
        public string RefDevis { get; set; }
        public bool Cloture { get; set; }
        public bool Archive { get; set; }
        public int SocieteId { get; set; }
        

        public Chantier(string chref, string type,string nom, int? cp, string lieu,string description,DateTime datedebut,DateTime datefin,
              decimal? heuresprevues,string zonedeplacement,string zonekm,string refdevis,bool cloture,bool archive,int societeid)
        {
            Ref = chref;
            Type = type;
            Nom = nom;
            CP = cp;
            Lieu = lieu;
            DateDebut = datedebut;
            DateFin = datefin;
            HeuresPrevues = heuresprevues;
            ZoneDeplacement = zonedeplacement;
            ZoneKm = zonekm;
            RefDevis = refdevis;
            Cloture = cloture;
            Archive = archive;
            SocieteId = societeid;
        }
        //// données retour de la Db
        public Chantier(int id,string chref, string type, string nom, int? cp, string lieu, string description, DateTime datedebut, DateTime datefin,
              decimal? heuresprevues, string zonedeplacement, string zonekm, string refdevis, bool cloture, bool archive, int societeid)
            : this(chref,type,nom,cp,lieu,description,datedebut,datefin,heuresprevues,zonedeplacement,zonekm,refdevis,cloture,archive,societeid)
        {
        Id = id;
           

        }
        public Chantier()
        { }

    }
}
