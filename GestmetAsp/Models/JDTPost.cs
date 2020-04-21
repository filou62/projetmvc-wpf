using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestmetAsp.Models
{
    public class JDTPost
    {
        public int PersonnelId { get; set; }
        public int PosteId { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DateChantier { get; set; }
      //  [RegularExpression(@"^(0|-?\d{0,16}(\,\d{0,2})?)$")]
        public decimal HeuresProd { get; set; }
        public bool VoitPerso { get; set; }
        public string ZoneDepl { get; set; }
        public int ChefChantierId { get; set; }
        public int Login { get; set; }
        public bool EstValide { get; set; }
        public IEnumerable<VPoste> Poste { get; set; }
        public IEnumerable<VPersonnel> Personnel { get; set; }
        public List<DateTime> ListeDate { get; set; }

    }
}