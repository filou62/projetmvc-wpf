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
    public class VChantierRepository : IRepositoryGlobal<VChantier>
    {
        IRepositoryGlobal<G.VChantier> _globalService;
        public VChantierRepository()
        {
            _globalService = new GS.VChantierRepository();
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
