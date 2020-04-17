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
    public class VPosteController : ApiController
    {
        private IRepositoryGlobal<VPoste> _service;
        public VPosteController()
        {
            _service = new VPosteRepository();
        }
        // GET api/<controller>
        [HttpGet]
        public IEnumerable<VPoste> Get()
        {
            return _service.GetAll();
        }
    }
}
