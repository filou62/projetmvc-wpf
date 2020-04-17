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
    public class VChantierController : ApiController
    {
        private IRepositoryGlobal<VChantier> _service;
        public VChantierController()
        {
            _service = new VChantierRepository();
        }
        // GET api/<controller>
        [HttpGet]
        public IEnumerable<VChantier> Get()
        {
            return _service.GetAll();
        }
    }
}
