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
    public class UtilisateurRepository : IRepositoryGlobalConnect<Utilisateur>
    {
        private IRepositoryGlobalConnect<G.Utilisateur> _globalService;

        public UtilisateurRepository()
        {
            _globalService = new S.UtilisateurRepository();
        }
        public int Create(Utilisateur entity)
        {
            return _globalService.Create(entity.ToGlobalUtilisateur());
        }

        public bool CreateNew(Utilisateur T)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            _globalService.Delete(id);
        }

        public IEnumerable<Utilisateur> GetAll()
        {
            return _globalService.GetAll().Select(c => c.ToClientUtilisateur());
        }

        public Utilisateur GetConnect(Utilisateur entity)
        {
            return _globalService.GetConnect(entity.ToGlobalUtilisateur()).ToClientUtilisateur();
        }

        public Utilisateur GetOne(int id)
        {
            return _globalService.GetOne(id)?.ToClientUtilisateur();
        }

        public void Update(int id, Utilisateur entity)
        {
            _globalService.Update(id, entity.ToGlobalUtilisateur());
        }
    }


}
