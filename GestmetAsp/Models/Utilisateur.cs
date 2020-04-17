using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CompareAttribute = System.ComponentModel.DataAnnotations.CompareAttribute;

namespace GestmetAsp.Models
{
    public class Utilisateur
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required]

        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage ="Adresse Eamil n'est pas valide !")]
        public string Email { get; set; }
        public string Login { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string MotPasse { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("MotPasse",ErrorMessage ="Votre mot de passe ne correspond pas !")]
        public string RepeatMotPasse { get; set; }
        [HiddenInput]
        public int PersonnelId { get; set; }
        // permet de savoir si l'utilisateur a valider son mot de passe par défaut et devient donc actif
        [HiddenInput]
        public bool EstActif { get; set; }
    }
}