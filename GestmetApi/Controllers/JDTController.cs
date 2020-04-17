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
    //[Route("[controller]")]
    public class JDTController : ApiController
    {
        private IRepositoryGlobal<JournalDesTravaux> _service;
        public JDTController()
        {
            _service = new JDTRepository();
        }
        // GET api/<controller>
        [HttpGet]
        public IEnumerable<JournalDesTravaux> Get()
        {
            return _service.GetAll();
        }

        [HttpGet]
        public JournalDesTravaux GetOne(int id)
        {
            return _service.GetOne(id);
        }

        // POST api/<controller>
        [HttpPost]
        public int Create(JDTPost jdtpost)
        //public int Create(JournalDesTravaux jdtpost)
        {
            return _service.Create(new JournalDesTravaux(jdtpost.PersonnelId, jdtpost.PosteId, jdtpost.DateChantier, jdtpost.HeuresProd, jdtpost.VoitPerso,
            jdtpost.ZoneDepl, jdtpost.ChefChantierId, jdtpost.Login,jdtpost.EstValide));
        }

        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}
        [HttpPut]
        public void Update(int id,JDTPost jdtpost)
        {
            _service.Update (id,new JournalDesTravaux(jdtpost.PersonnelId, jdtpost.PosteId, jdtpost.DateChantier, jdtpost.HeuresProd, jdtpost.VoitPerso,
            jdtpost.ZoneDepl, jdtpost.ChefChantierId, jdtpost.Login,jdtpost.EstValide));
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}