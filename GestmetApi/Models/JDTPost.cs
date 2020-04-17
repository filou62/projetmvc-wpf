using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestmetApi.Models
{
    public class JDTPost
    {
        
        public int PersonnelId { get; set; }
        public int PosteId { get; set; }
        public DateTime DateChantier { get; set; }
        public decimal HeuresProd { get; set; }
        public bool VoitPerso { get; set; }
        public string ZoneDepl { get; set; }
        public int ChefChantierId { get; set; }
        public int Login { get; set; }
        public bool EstValide { get; set; }

    }
}