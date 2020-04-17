using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestmetModelsGlobal
{
    public class Chantier
    {
        public int Id { get; set; }
        public string Ref { get; set; }
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
        
    }
}
