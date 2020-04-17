using GestmetModelsClient.Mappers;
using GestmetModelsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G = GestmetModelsGlobal;
using GS = GestmetModelsGlobal.Services;

namespace GestmetModelsClient.Services
{
    public class VPosteRepository : IRepositoryGlobal<VPoste>
    {
        IRepositoryGlobal<G.VPoste> _globalService;
        public VPosteRepository()
        {
            _globalService = new GS.VPosteRepository();
        }
        public int Create(VPoste T)
        {
            throw new NotImplementedException();
        }

        public bool CreateNew(VPoste T)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VPoste> GetAll()
        {
            return _globalService.GetAll().Select(c => c.ToClientVPoste());
        }

        public VPoste GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, VPoste T)
        {
            throw new NotImplementedException();
        }
    }
}
