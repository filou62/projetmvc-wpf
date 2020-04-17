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
    public class VPersonnelRepository : IRepositoryGlobal<Personnel>
    {
        IRepositoryGlobal<G.Personnel> _globalService;
        public VPersonnelRepository()
        {
            _globalService = new GS.VPersonnelRepository();
        }
        public int Create(Personnel T)
        {
            throw new NotImplementedException();
        }

        public bool CreateNew(Personnel T)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Personnel> GetAll()
        {
            return _globalService.GetAll().Select(c => c.ToClientVPersonnel());
        }

        public Personnel GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Personnel T)
        {
            throw new NotImplementedException();
        }
    }
}
