using GestmetAsp.Models;
using GestmetModelsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using UIGestmetModelsClient.Services;

namespace GestmetAsp.Utils
{
    public class GetDbListView
    {
        private IRepositoryGlobal<UIGestmetModelsClient.VPoste> _servicePoste;
        private IRepositoryGlobal<UIGestmetModelsClient.Personnel> _servicePersonnel;
        private IRepositoryGlobal<UIGestmetModelsClient.VChantier> _serviceChantier;
        
        public  IEnumerable<VPoste> GetVPostes()
        {
            _servicePoste = new VPosteRepository();
            IEnumerable<VPoste> VPosteList = _servicePoste.GetAll().Select(s => new VPoste()
            {
                IdPoste = s.IdPoste,
                RefPoste = s.RefPoste,
                LibellePoste = s.LibellePoste,
                ChantierId = s.ChantierId,
                RefChantier = s.RefChantier,
                NomChantier = s.NomChantier,
                LieuChantier = s.LieuChantier
            });
            return VPosteList;
        }
        public IEnumerable<VPersonnel> GetVPersonnels()
        {
            _servicePersonnel = new VPersonnelRepository();
            IEnumerable<VPersonnel> VPersonnelList = _servicePersonnel.GetAll().Select(s => new VPersonnel()
            {
                Id = s.Id,
                Matricule = s.Matricule,
                Prenom = s.Prenom,
                Nom = s.Nom,
                ChefEquipe = s.ChefEquipe
            });
            return VPersonnelList;
        }
        public IEnumerable<VChantier> GetVChantiers()
        {
            _serviceChantier = new VChantierRepository();
            IEnumerable<Models.VChantier> VChantierList = _serviceChantier.GetAll().Select(s => new VChantier()
            {
                Id = s.Id,
                Ref = s.Ref,
                Nom = s.Nom,
                Lieu = s.Lieu,
                VNomSociete = s.VNomSociete
            });
            return VChantierList;
        }
    }
}