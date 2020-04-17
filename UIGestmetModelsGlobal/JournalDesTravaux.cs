using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIGestmetModelsGlobal
{
    public class JournalDesTravaux
    {
        public int Id { get; set; }
        public int PersonnelId { get; set; }
        public int PosteId { get; set; }
        public DateTime DateChantier { get; set; }
        public decimal HeuresProd { get; set; }
        public bool VoitPerso { get; set; }
        public string ZoneDepl { get; set; }
        public int ChefChantierId { get; set; }
        public int Login { get; set; }
        public int NumSemaine { get; set; }
        public bool EstValide { get; set; }
    }
}
