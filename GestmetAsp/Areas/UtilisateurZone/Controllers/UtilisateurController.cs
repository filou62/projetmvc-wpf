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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(DateTime datedebut)
        {
            if (SessionManager.SessionUser != null)
            {
                TempData["estdisplay"] = "oui";
                if(int()datedebut.DayOfWeek != 1 )
                {
                    ViewBag.Message = "La date de recherche n'est pas un lundi ou est nulle";
                    TempData["estdisplay"] = "non";
                    return View();
                }
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
                }).Where(jdt => jdt.PersonnelId == SessionManager.SessionUser.PersonnelId
                             && (jdt.DateChantier >= datedebut & jdt.DateChantier <= (datedebut.AddDays(6)))));
            }
            else
                return RedirectToAction("../../Home/Index");
        }
        [HttpGet]
        public ActionResult Index()
        {
            if (SessionManager.SessionUser != null)
            { 
            TempData.Add("estdisplay", "non");
            return View();
            }
            else
            return RedirectToAction("../../Home/Index");
        }
    }
}