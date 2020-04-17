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
    public class JDTRepository : IRepositoryGlobal<JournalDesTravaux>
    {
        IRepositoryGlobal<G.JournalDesTravaux> _globalService;
        public JDTRepository()
        {
            _globalService = new GS.JDTRepository();
        }
          
        public int Create(JournalDesTravaux T)
        {
            return _globalService.Create(T.ToGlobalJDT());
        }

        public bool CreateNew(JournalDesTravaux T)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            _globalService.Delete(id);
        }

        public IEnumerable<JournalDesTravaux> GetAll()
        {
            return _globalService.GetAll().Select(c => c.ToClientJDT());
        }

        public JournalDesTravaux GetOne(int id)
        {
            return _globalService.GetOne(id)?.ToClientJDT();
        }

        public void Update(int id, JournalDesTravaux T)
        {
            _globalService.Update(id,T.ToGlobalJDT());
        }
    }
}
