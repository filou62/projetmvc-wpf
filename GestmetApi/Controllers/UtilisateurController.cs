using GestmetApi.Models;
using GestmetModelsClient;
using GestmetModelsClient.Services;
using GestmetModelsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GestmetApi.Controllers
{
    public class UtilisateurController : ApiController
    {
        private IRepositoryGlobalConnect<GestmetModelsClient.Utilisateur> _service;
        public UtilisateurController()
        {
            _service = new UtilisateurRepository();
        }
        // GET: api/Utilisateur
        [HttpGet]
        public IEnumerable<GestmetModelsClient.Utilisateur> Get()
        {
            return _service.GetAll();
        }

        // GET: api/Utilisateur/5
        [HttpGet]
        public GestmetModelsClient.Utilisateur GetOne(int id)
        {
            return _service.GetOne(id);
        }

        //// POST: api/Utilisateur
        [HttpPost]
        [Route("api/Utilisateur/register")]
        public int Create(Models.Utilisateur utilisateur)
        {
            return _service.Create(new GestmetModelsClient.Utilisateur(utilisateur.Email, utilisateur.Login, utilisateur.MotPasse, utilisateur.PersonnelId, utilisateur.EstActif));
        }

        // PUT: api/Utilisateur/5
        [HttpPut]
        public void Update(int id,Models.Utilisateur utilisateur)
        {
            _service.Update(id, new GestmetModelsClient.Utilisateur(utilisateur.Id, utilisateur.Email, utilisateur.Login, utilisateur.MotPasse, utilisateur.PersonnelId, utilisateur.EstActif));
        }

        // DELETE: api/Utilisateur/5
        [HttpDelete]
        public void Delete(int id)
        {
            _service.Delete(id);
        }
        [HttpPost]
        [Route("api/Utilisateur/login")]
        public GestmetModelsClient.Utilisateur GetConnect(Models.Utilisateur utilisateur)
        {
            return _service.GetConnect(new GestmetModelsClient.Utilisateur(utilisateur.Id, utilisateur.Email, utilisateur.Login, utilisateur.MotPasse, utilisateur.PersonnelId, utilisateur.EstActif));
        }
    }
}
