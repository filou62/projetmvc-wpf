using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIGestmetModelsClient
{
   public class Utilisateur
    {
        public int Id { get; private set; }
        public string Email { get; private set; }
        public string Login { get; private set; }
        public string MotPasse { get; private set; }
        public int PersonnelId { get; private set; }
        // permet de savoir si l'utilisateur a valider son mot de passe par défaut et devient donc actif
        public bool EstActif { get; private set; }
        public Utilisateur(string email, string login, string motpasse, int personnelid, bool estactif)
        {
            Email = email;
            Login = login;
            MotPasse = motpasse;
            PersonnelId = personnelid;
            EstActif = estactif;
        }
        // données retour de la Db
        public Utilisateur(int utilisateurid, string email, string login, string motpasse, int personnelid, bool estactif)
            : this(email, login, motpasse, personnelid, estactif)
        {
            Id = utilisateurid;
        }
    }
}
