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
    public class VChantierRepository : IRepositoryGlobal<VChantier>
    {
        private IRepositoryGlobal<G.VChantier> _globalService;
        public VChantierRepository()
        {
            _globalService = new S.VChantierRepository();
        }
        public int Create(VChantier T)
        {
            throw new NotImplementedException();
        }

        public bool CreateNew(VChantier T)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VChantier> GetAll()
        {
            return _globalService.GetAll().Select(c => c.ToClientVChantier());
        }

        public VChantier GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, VChantier T)
        {
            throw new NotImplementedException();
        }
    }
}
