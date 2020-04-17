using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestmetApi.Models
{
    public class Utilisateur
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string MotPasse { get; set; }
        public int PersonnelId { get; set; }
        // permet de savoir si l'utilisateur a valider son mot de passe par défaut et devient donc actif
        public bool EstActif { get; set; }
    }
}