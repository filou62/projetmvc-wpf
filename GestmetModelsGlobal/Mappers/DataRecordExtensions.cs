using System;
using System.Data;

namespace GestmetModelsGlobal.Mappers
{
    internal static class DataRecordExtensions
    {
        internal static JournalDesTravaux ToJDT(this IDataRecord dataRecord)
        {
            return new JournalDesTravaux()
            {
                Id = (int)dataRecord["JDTId"],
                PersonnelId = (int)dataRecord["PersonnelId"],
                PosteId = (int)dataRecord["PosteId"],
                DateChantier = (DateTime)dataRecord["DateChantier"],
                HeuresProd = (decimal)dataRecord["HeuresProd"],
                VoitPerso = Convert.ToBoolean(dataRecord["VoitPerso"]),
                ZoneDepl = (string)dataRecord["ZoneDepl"],
                ChefChantierId = (int)dataRecord["ChefChantierId"],
                Login = (int)dataRecord["Login"],
                NumSemaine = (int)dataRecord["NumSemaine"],  
                EstValide = (bool)dataRecord["EstValide"]
            };
        }
        internal static VChantier ToVChantier(this IDataRecord dataRecord)
        {
            return new VChantier()
            {
                Id=(int)dataRecord["ChantierId"],
                Ref = (string)dataRecord["RefChantier"],
                Nom = (string)dataRecord["NomChantier"],
                Lieu = (dataRecord["LieuChantier"] is DBNull) ? null : (string)dataRecord["LieuChantier"],
                VNomSociete= (string)dataRecord["NomSociete"]
             };
        }
        internal static Personnel ToVPersonnel(this IDataRecord dataRecord)
        {
            return new Personnel()
            {
                Id = (int)dataRecord["PersonnelId"],
                Matricule = (int)dataRecord["Matricule"],
                Prenom = (string)dataRecord["Prenom"],
                Nom = (string)dataRecord["Nom"],
                ChefEquipe = (bool)dataRecord["ChefEquipe"],
                //SocieteId=(int)dataRecord["Societe"]
            };
        }
        internal static VPoste ToVPoste(this IDataRecord dataRecord)
        {
            return new VPoste()
            {
                ChantierId = (int)dataRecord["ChantierId"],
                RefChantier = (string)dataRecord["RefChantier"],
                NomChantier = (string)dataRecord["NomChantier"],
                LieuChantier = (dataRecord["LieuChantier"] is DBNull) ? null : (string)dataRecord["LieuChantier"],
                IdPoste = (int)dataRecord["PosteId"],
                RefPoste = (int)dataRecord["REfPoste"],
                LibellePoste = (string)dataRecord["LibellePoste"]
            };
        }
        internal static Utilisateur ToUtilisateur(this IDataRecord dataRecord)
        {
            return new Utilisateur()
            {
                Id = (int)dataRecord["UtilisateurId"],
                Email = (string)dataRecord["Email"],
                Login = (string)dataRecord["Login"],
               // MotPasse = (string)dataRecord["MotPasse"],
                PersonnelId = (int)dataRecord["PersonnelId"],
                EstActif = (bool)dataRecord["EstActif"]              
            };
        }
    }
}
