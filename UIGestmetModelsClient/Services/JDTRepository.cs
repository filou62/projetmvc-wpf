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
    public class JDTRepository : IRepositoryGlobal<JournalDesTravaux>
    {
        private IRepositoryGlobal<G.JournalDesTravaux> _globalService;

        public JDTRepository()
        {
            _globalService = new S.JDTRepository();
        }
        public int Create(JournalDesTravaux entity)
        {
            return _globalService.Create(entity.ToGlobalJDT());
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

        public void Update(int id, JournalDesTravaux entity)
        {
            _globalService.Update(id,entity.ToGlobalJDT());
        }
    }
}
