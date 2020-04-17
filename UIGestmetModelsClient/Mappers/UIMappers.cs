using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G = UIGestmetModelsGlobal;

namespace UIGestmetModelsClient.Mappers
{
    internal static class UIMappers
    {
        internal static G.JournalDesTravaux ToGlobalJDT(this JournalDesTravaux entity)
        {
            return new G.JournalDesTravaux()
            {
                Id = entity.Id,
                PersonnelId = entity.PersonnelId,
                PosteId = entity.PosteId,
                DateChantier = entity.DateChantier,
                HeuresProd = entity.HeuresProd,
                VoitPerso = entity.VoitPerso,
                ZoneDepl = entity.ZoneDepl,
                ChefChantierId = entity.ChefChantierId,
                Login = entity.Login,
                NumSemaine = entity.NumSemaine,
                EstValide = entity.EstValide
            };
        }

        internal static JournalDesTravaux ToClientJDT(this G.JournalDesTravaux entity)
        {
            return new JournalDesTravaux(entity.Id,entity.PersonnelId,entity.PosteId, entity.DateChantier,entity.HeuresProd,entity.VoitPerso,entity.ZoneDepl,entity.ChefChantierId,entity.Login,entity.NumSemaine,entity.EstValide);
        }
        internal static VPoste ToClientVPoste(this G.VPoste entity)
        {
            return new VPoste(entity.IdPoste, entity.RefPoste, entity.LibellePoste, entity.ChantierId, entity.RefChantier, entity.NomChantier, entity.LieuChantier);
        }
        internal static Personnel ToClientVPersonnel(this G.Personnel entity)
        {
            return new Personnel(entity.Id,entity.Matricule, entity.Prenom, entity.Nom, entity.DateNaissance, entity.Qualification, entity.ChefEquipe, entity.SocieteId);
        }
        internal static VChantier ToClientVChantier(this G.VChantier entity)
        {
            return new VChantier(entity.Id, entity.Ref, entity.Nom, entity.Lieu, entity.VNomSociete);
        }
        internal static G.Utilisateur ToGlobalUtilisateur(this Utilisateur entity)
        {
            return new G.Utilisateur()
            {
                Id = entity.Id,
                Email = entity.Email,
                Login = entity.Login,
                MotPasse = entity.MotPasse,
                PersonnelId = entity.PersonnelId,
                EstActif = entity.EstActif
            };
        }

        internal static Utilisateur ToClientUtilisateur(this G.Utilisateur entity)
        {
            return new Utilisateur(entity.Id, entity.Email, entity.Login, entity.MotPasse, entity.PersonnelId, entity.EstActif);
        }
    }
}
