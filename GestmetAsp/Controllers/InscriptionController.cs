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
    public class InscriptionController : Controller
    {
        private IRepositoryGlobalConnect<UIGestmetModelsClient.Utilisateur> _serviceutilisateur;

        public InscriptionController()
        {
            _serviceutilisateur = new UtilisateurRepository();
        }
        // GET: Inscription
        public ActionResult Index()
        {
            return View();
        }

        // GET: Inscription/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Inscription/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Inscription/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Inscription/Edit/5
        public ActionResult Edit(int id)
        {
            UIGestmetModelsClient.Utilisateur u = _serviceutilisateur.GetOne(id);
            return View(new Models.Utilisateur()
            {
                Id = u.Id,
                Email=u.Email,
                Login=u.Login,
                MotPasse=u.MotPasse,
                PersonnelId=u.PersonnelId,
                EstActif=u.EstActif
            });
        }

        // POST: Inscription/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Models.Utilisateur utilisateur)
        {
            try
            {
                _serviceutilisateur.Update(id, new UIGestmetModelsClient.Utilisateur(
                    utilisateur.Email, utilisateur.Login, utilisateur.MotPasse, utilisateur.PersonnelId, true));

                return RedirectToAction("../Home/Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Inscription/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Inscription/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult UpdateUtilisateur()
        {
            //UserRepository ur = new UserRepository();
            ViewBag.Message = "Inscrivez-vous";
            return View(new Models.Utilisateur());

        }
        [HttpPost]
        [ValidateAntiForgeryToken]//très important à mettre pour la securite a mettre egalement dans la view correspondante
        public ActionResult UpdateUtilisateur(Models.Utilisateur T)
        {

            try
            {
                UIGestmetModelsClient.Utilisateur utilisateur =
                _serviceutilisateur.GetConnect(new UIGestmetModelsClient.Utilisateur(T.Email, T.Login, T.MotPasse, T.PersonnelId, T.EstActif));
                Models.Utilisateur ur = new Models.Utilisateur()
                {
                    Id = utilisateur.Id,
                    Email = utilisateur.Email,
                    Login = utilisateur.Login,
                    MotPasse = utilisateur.MotPasse,
                    PersonnelId = utilisateur.PersonnelId,
                    EstActif = utilisateur.EstActif
                };


                if (ur.Id == 0)
                { ViewBag.Message = "Votre Login et/ou mot de passe est incorrect";
                    // return RedirectToAction("../Home/Index");
                    return View();

                }
                if (ur.EstActif)
                {
                    ViewBag.Message = "Vous êtes déjà inscrit";
                    return View();
                   // return RedirectToAction("../Home/Index");
                }
                else
                    return RedirectToAction("Edit",new  {id =ur.Id });
            }
            catch (Exception e)
            {
                return Content(e.ToString());
                //return View();
            }

        }
    }
}
