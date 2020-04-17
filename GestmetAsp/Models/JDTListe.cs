using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestmetAsp.Models
{
    public class JDTListe
    {
        public int Id { get; set; }
        public int PersonnelId { get; set; }
        public int PosteId { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DateChantier { get; set; }
       // [RegularExpression(@"^(0|-?\d{0,16}(\,\d{0,2})?)$")]
        public decimal HeuresProd { get; set; }
        public bool VoitPerso { get; set; }
        public string ZoneDepl { get; set; }
        public int ChefChantierId { get; set; }
        public int Login { get; set; }
        public int NumSemaine { get; set; }
        public bool EstValide { get; set; }
    }
}