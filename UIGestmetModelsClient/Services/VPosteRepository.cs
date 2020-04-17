using GestmetModelsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S = UIGestmetModelsGlobal.Services;
using G = UIGestmetModelsGlobal;
using UIGestmetModelsClient.Mappers;

namespace UIGestmetModelsClient.Services
{
    public class VPosteRepository : IRepositoryGlobal<VPoste>
    {
        private IRepositoryGlobal<G.VPoste> _globalService;
        public VPosteRepository()
        {
            _globalService = new S.VPosteRepository();
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
