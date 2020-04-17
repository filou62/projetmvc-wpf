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
    public class VPersonnelController : ApiController
    {
        private IRepositoryGlobal<Personnel> _service;
        public VPersonnelController()
        {
            _service = new VPersonnelRepository();
        }
        // GET api/<controller>
        [HttpGet]
        public IEnumerable<Personnel> Get()
        {
            return _service.GetAll();
        }
    }
}
