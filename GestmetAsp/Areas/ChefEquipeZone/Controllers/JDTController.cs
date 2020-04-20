using GestmetAsp.Models;
using GestmetAsp.Utils;
using GestmetModelsInterfaces;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using UIGestmetModelsClient;
using UIGestmetModelsClient.Services;

namespace GestmetAsp.Areas.ChefEquipeZone.Controllers
{
    public class JDTController : Controller
    {
        private IRepositoryGlobal<JournalDesTravaux> _serviceJDT;
        private GetDbListView vgetlist;
        public JDTController()
        {
            _serviceJDT = new JDTRepository();
            vgetlist = new GetDbListView();
        }
//.........................................***********INIT************...............................................
        [HttpGet]
        public ActionResult Init()
        {
            IEnumerable<Models.VChantier> listchoixchantier = vgetlist.GetVChantiers();
            ViewData["viewlistchantier"] = listchoixchantier;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Init(DateTime? datedebut, int? choixchantier)
        {
            if (datedebut == null || (int)((DateTime)datedebut).DayOfWeek != 1)
            {
                ViewBag.Message = "La date de recherche n'est pas un lundi ou n'est pas valable";
                return View();
            }
            TempData["choixchantier"] = (int)choixchantier;
            TempData["datedebut"] = (DateTime)datedebut;
            return RedirectToAction("Index", new { choixchantier = @TempData["choixchantier"], datedebut = @TempData["datedebut"] });

        }
        //.........................................***********INDEX************...............................................       
        [HttpGet]
        public ActionResult Index(DateTime datedebut,int choixchantier)
        {
            if (SessionManager.SessionUser != null)
            {
                TempData["choixchantier"] = choixchantier;
                TempData["datedebut"] = datedebut;
                IEnumerable<Models.VPoste> listposte = vgetlist.GetVPostes();
                return View("Index", _serviceJDT.GetAll().Select(s => new JDTListe()
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
                })
                .Where(jdt => jdt.ChefChantierId == SessionManager.SessionUser.PersonnelId
                && (listposte.FirstOrDefault(lp => lp.IdPoste == jdt.PosteId).ChantierId == (int)TempData["choixchantier"])
                && (jdt.DateChantier >= (DateTime)TempData["datedebut"] & jdt.DateChantier <= ((DateTime)TempData["datedebut"]).AddDays(6))));


            }
            return RedirectToAction("../../Home/Index");
        }
//.........................................***********DETAILS************...............................................              
        public ActionResult Details(int id, DateTime datedebut, int choixchantier)
        {
            if (SessionManager.SessionUser != null)
            {
                JournalDesTravaux s = _serviceJDT.GetOne(id);
                TempData["choixchantier"] = choixchantier;
                TempData["datedebut"] = datedebut;
                return View(new JDTListe()
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
                });
            }
            else
                return RedirectToAction("../../Home/Index");
        }

//.........................................***********CREATE************...............................................       
        [HttpGet]
        public ActionResult Create(DateTime datedebut, int choixchantier)
        {
            if (SessionManager.SessionUser != null)
            {
                TempData["choixchantier"] = choixchantier;
                TempData["datedebut"] = datedebut;
                JDTPost jdtpost = new JDTPost();
                jdtpost.Poste = vgetlist.GetVPostes().Where(p => p.ChantierId == (int)TempData["choixchantier"]);
                jdtpost.Personnel = vgetlist.GetVPersonnels();
                
                return View("Create", jdtpost);
            }
            else
                return RedirectToAction("../../Home/Index");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DateTime datedebut, int choixchantier, JDTPost jdtpost)
        {
            if (SessionManager.SessionUser != null)
            {
                try
                {
                    TempData["choixchantier"] = choixchantier;
                    TempData["datedebut"] = datedebut;
                    _serviceJDT.Create(new JournalDesTravaux(jdtpost.PersonnelId, jdtpost.PosteId, jdtpost.DateChantier, jdtpost.HeuresProd, jdtpost.VoitPerso, jdtpost.ZoneDepl, SessionManager.SessionUser.PersonnelId, SessionManager.SessionUser.PersonnelId, jdtpost.EstValide));

                    return RedirectToAction("Index", new { choixchantier = @TempData["choixchantier"], datedebut = @TempData["datedebut"] });
                }
                catch (Exception ex)
                {
                    return View();
                }
            }
            else
                return RedirectToAction("../../Home/Index");
        }
//.........................................***********EDIT************...............................................   
        [HttpGet]
        public ActionResult Edit(int id,DateTime datedebut,int choixchantier)
        {
            if (SessionManager.SessionUser != null)
            {
                JournalDesTravaux s = _serviceJDT.GetOne(id);
                TempData["choixchantier"] = choixchantier;
                TempData["datedebut"] = datedebut;
                return View(new JDTPost()
                {
                    //Id = s.Id,
                    PersonnelId = s.PersonnelId,
                    PosteId = s.PosteId,
                    DateChantier = s.DateChantier,
                    HeuresProd = s.HeuresProd,
                    VoitPerso = s.VoitPerso,
                    ZoneDepl = s.ZoneDepl,
                    ChefChantierId = s.ChefChantierId,
                    Login = s.Login,
                    //NumSemaine = s.NumSemaine,
                    EstValide = s.EstValide,
                    Poste = vgetlist.GetVPostes().Where(p => p.ChantierId == (int)TempData["choixchantier"]),
                    Personnel = vgetlist.GetVPersonnels()
                }); 
            }
            else
                return RedirectToAction("../../Home/Index");
        }

        // POST: JDT/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, DateTime datedebut, int choixchantier,  JDTPost jdtpost)
        {
            if (SessionManager.SessionUser != null)
            {
                try
                {
                    _serviceJDT.Update(id, new JournalDesTravaux(jdtpost.PersonnelId, jdtpost.PosteId, jdtpost.DateChantier, jdtpost.HeuresProd, jdtpost.VoitPerso, jdtpost.ZoneDepl, jdtpost.ChefChantierId,SessionManager.SessionUser.PersonnelId, jdtpost.EstValide));
                    TempData["choixchantier"] = choixchantier;
                    TempData["datedebut"] = datedebut;
                    return RedirectToAction("Index", new {choixchantier = @TempData["choixchantier"], datedebut = @TempData["datedebut"] });
                }
                catch (Exception ex)
                {
                    return View();
                }
            }
            else
                return RedirectToAction("../../Home/Index");
        }
        //.........................................***********DELETE************...............................................   
        //  [HttpDelete]
        public ActionResult Delete(int id, DateTime datedebut, int choixchantier)
        {
            if (SessionManager.SessionUser != null)
            {
                TempData["choixchantier"] = choixchantier;
                TempData["datedebut"] = datedebut;
                _serviceJDT.Delete(id);
                return RedirectToAction("Index", new { choixchantier = @TempData["choixchantier"], datedebut = @TempData["datedebut"] });
            }
            else
                return RedirectToAction("../../Home/Index");
        }
    }
}
