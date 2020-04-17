using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIGestmetModelsClient
{
    public class JournalDesTravaux
    {
        public int Id { get; private set; }
        public int PersonnelId { get; private set; }
        public int PosteId { get; private set; }
        public DateTime DateChantier { get; private set; }
        public decimal HeuresProd { get; private set; }
        public bool VoitPerso { get; private set; }
        public string ZoneDepl { get; private set; }
        public int ChefChantierId { get; private set; }
        public int Login { get; private set; }
        public int NumSemaine { get; private set; }
        public bool EstValide { get; private set; }

        public JournalDesTravaux(int personnelid, int posteid, DateTime datechantier, decimal heuresprod, bool voitperso,
            string zonedepl, int chefchantierid, int login, bool estvalide)
        {
            PersonnelId = personnelid;
            PosteId = posteid;
            DateChantier = datechantier;
            HeuresProd = heuresprod;
            VoitPerso = voitperso;
            ZoneDepl = zonedepl;
            ChefChantierId = chefchantierid;
            Login = login;
            EstValide = estvalide;
        }
        // données retour de la Db
        public JournalDesTravaux(int id, int personnelid, int posteid, DateTime datechantier, decimal heuresprod, bool voitperso,
            string zonedepl, int chefchantierid, int login, int numsemaine,bool estvalide)
            : this(personnelid, posteid, datechantier, heuresprod, voitperso, zonedepl, chefchantierid, login, estvalide)
        {
            Id = id;
            NumSemaine = numsemaine;
            
        }
    }
}
