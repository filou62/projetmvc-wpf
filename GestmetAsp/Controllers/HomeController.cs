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

namespace GestmetAsp.Controllers
{
    public class HomeController : Controller
    {
        private IRepositoryGlobalConnect<UIGestmetModelsClient.Utilisateur> _serviceutilisateur;
        
        public HomeController()
        {
            _serviceutilisateur = new UtilisateurRepository();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "GESTMET";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "SOCIETE L.......B";

            return View();
        }
        public ActionResult Connection()
        {
            //UserRepository ur = new UserRepository();
            ViewBag.Message = "Connectez-vous";
            return View(new Models.Utilisateur());

        }
        [HttpPost]
        [ValidateAntiForgeryToken]//très important à mettre pour la securite a mettre egalement dans la view correspondante
        public ActionResult Connection(Models.Utilisateur T)
        {
            
            try
            {
                UIGestmetModelsClient.Utilisateur utilisateur =
                _serviceutilisateur.GetConnect(new UIGestmetModelsClient.Utilisateur(T.Email, T.Login, T.MotPasse, T.PersonnelId, T.EstActif));
                



            if (utilisateur.EstActif)
                { 
                    SessionManager.SessionUser = new Models.Utilisateur()
                    {
                    Id = utilisateur.Id,
                    Email = utilisateur.Email,
                    Login = utilisateur.Login,
                    MotPasse = utilisateur.MotPasse,
                    PersonnelId = utilisateur.PersonnelId,
                    EstActif = utilisateur.EstActif
                    };
                    return RedirectToAction("../Home/Index");
                }    
             else
               {
                    
                    ViewBag.Message = "Vous devez vous inscrire avant de vous connecter : retour à l'accueil";
                    return View();
                    //return RedirectToAction("../Home/Index"); 
                }

                    
            }
            catch (Exception e)
            {
                return Content(e.ToString());
                //return View();
            }

        }
        public ActionResult DéConnection()
        { SessionManager.SessionUser = null; return RedirectToAction("../Home/Index"); }
    }
}