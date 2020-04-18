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

namespace GestmetAsp.Areas.ChefEquipeZone.Controllers
{
    public class JDTController : Controller
    {
        private IRepositoryGlobal<JournalDesTravaux> _serviceJDT;
        //private IRepositoryGlobal<UIGestmetModelsClient.VPoste> _servicePoste;
        //private IRepositoryGlobal<UIGestmetModelsClient.Personnel> _servicePersonnel;
        //private IRepositoryGlobal<UIGestmetModelsClient.VChantier> _serviceChantier;
        private GetDbListView vgetlist;
        public JDTController()
        {
            _serviceJDT = new JDTRepository();
            //_servicePoste = new VPosteRepository();
            //_servicePersonnel = new VPersonnelRepository();
            //_serviceChantier = new VChantierRepository();
            vgetlist = new GetDbListView();
        }
        // GET: JDT
        public ActionResult Index()
        {
            if (SessionManager.SessionUser != null)
            {
                return View(_serviceJDT.GetAll().Select(s => new JDTListe()
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
                }));
            }
            else
                return RedirectToAction("../../Home/Index");
        }

        //GET: JDT/Details/5
        public ActionResult Details(int id)
        {
            if (SessionManager.SessionUser != null)
            {
                JournalDesTravaux s = _serviceJDT.GetOne(id);
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

        // GET: JDT/Create
        public ActionResult Create()
        {
            if (SessionManager.SessionUser != null)
            {
                JDTPost jdtpost = new JDTPost();
                //GetDbListView VGetList = new GetDbListView();
                //..........Vue POSTE...........................//

                //IEnumerable<Models.VPoste> VPosteList = _servicePoste.GetAll().Select(s=>new Models.VPoste()
                //{IdPoste=s.IdPoste,
                //RefPoste=s.RefPoste,
                //LibellePoste=s.LibellePoste,
                //ChantierId=s.ChantierId,
                //RefChantier=s.RefChantier,
                //NomChantier=s.NomChantier,
                //LieuChantier=s.LieuChantier
                //});
                jdtpost.Poste = vgetlist.GetVPostes();
                //..........Vue PERSONNEL...........................//
                //IEnumerable<Models.VPersonnel> VPersonnelList = _servicePersonnel.GetAll().Select(s => new Models.VPersonnel()
                //{
                //    Id = s.Id,
                //    Matricule = s.Matricule,
                //    Prenom = s.Prenom,
                //    Nom = s.Nom,
                //    ChefEquipe = s.ChefEquipe
                //    });
                jdtpost.Personnel = vgetlist.GetVPersonnels();
                //................................................................................//
                //..........Vue CHANTIER A PLACER DANS UN AUTRE CONTROLER?...........................//

                //IEnumerable<Models.VChantier> VChantierList = _serviceChantier.GetAll().Select(s => new Models.VChantier()
                //{
                //    Id = s.Id,
                //    Ref = s.Ref,
                //    Nom = s.Nom,
                //    Lieu = s.Lieu,
                //    VNomSociete = s.VNomSociete

                //});
                //................................................................................//

                return View("Create", jdtpost);
            }
            else
                return RedirectToAction("../../Home/Index");
        }

        // POST: JDT/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(JDTPost jdtpost)
        {
            if (SessionManager.SessionUser != null)
            {
                try
                {
                    _serviceJDT.Create(new JournalDesTravaux(jdtpost.PersonnelId, jdtpost.PosteId, jdtpost.DateChantier, jdtpost.HeuresProd, jdtpost.VoitPerso, jdtpost.ZoneDepl, jdtpost.ChefChantierId,SessionManager.SessionUser.PersonnelId, jdtpost.EstValide));

                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    return View();
                }
            }
            else
                return RedirectToAction("../../Home/Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            if (SessionManager.SessionUser != null)
            {
                JournalDesTravaux s = _serviceJDT.GetOne(id);
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
                    Poste = vgetlist.GetVPostes(),
                    Personnel = vgetlist.GetVPersonnels()



                });
            }
            else
                return RedirectToAction("../../Home/Index");
        }

        // POST: JDT/Edit/5
        [HttpPost]
        public ActionResult Edit(int id,  JDTPost jdtpost)
        {
            if (SessionManager.SessionUser != null)
            {
                try
                {
                    _serviceJDT.Update(id, new JournalDesTravaux(jdtpost.PersonnelId, jdtpost.PosteId, jdtpost.DateChantier, jdtpost.HeuresProd, jdtpost.VoitPerso, jdtpost.ZoneDepl, jdtpost.ChefChantierId,SessionManager.SessionUser.PersonnelId, jdtpost.EstValide));

                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    return View();
                }
            }
            else
                return RedirectToAction("../../Home/Index");
        }

      //  [HttpDelete]
        public ActionResult Delete(int id)
        {
            if (SessionManager.SessionUser != null)
            {
                _serviceJDT.Delete(id);
                return RedirectToAction("Index");
            }
            else
                return RedirectToAction("../../Home/Index");
        }

        // POST: JDT/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
        [HttpPost]
        public ActionResult Test(int retid)
        {
            int testid = retid;
            TempData["estdisplay"] = "oui";
            if (SessionManager.SessionUser != null)
            {
                return View("Test",_serviceJDT.GetAll().Select(s => new JDTListe()
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
                }));
            }
            else
                return RedirectToAction("../../Home/Index");
        }
        [HttpGet]
        public ActionResult Test()
        
        {
            
            TempData.Add("estdisplay", "non");
                       
            return View();
        }
    }
}
