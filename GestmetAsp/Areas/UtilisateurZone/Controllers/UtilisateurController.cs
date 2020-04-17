using GestmetAsp.Models;
using GestmetAsp.Utils;
using GestmetModelsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UIGestmetModelsClient;
using UIGestmetModelsClient.Services;

namespace GestmetAsp.Areas.UtilisateurZone.Controllers
{
    public class UtilisateurController : Controller
    {
       
        private IRepositoryGlobal<JournalDesTravaux> _serviceUtilisateur;
        
        public UtilisateurController()
        {
            _serviceUtilisateur = new JDTRepository();
            
        }
        // GET: JDT
        public ActionResult Index()
        {
            if (SessionManager.SessionUser != null)
            {
                return View(_serviceUtilisateur.GetAll().Select(s => new JDTListe()
                {
                    Id = s.Id,
                    PersonnelId = s.PersonnelId,
                    PosteId = s.PosteId,
                    DateChantier = s.DateChantier,
                    HeuresProd = s.HeuresProd,
                    VoitPerso = s.VoitPerso,
                    ZoneDepl = s.ZoneDepl,
                    ChefChantierId = s.ChefChantierId,
                    Login = s.Login,
                    NumSemaine = s.NumSemaine,
                    EstValide = s.EstValide
                }).Where(jdt => jdt.PersonnelId == SessionManager.SessionUser.PersonnelId));
            }
            else
                return RedirectToAction("../../Home/Index");
        }
    }
}