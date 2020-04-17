using GestmetModelsClient.Mappers;
using GestmetModelsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G = GestmetModelsGlobal;
using GS = GestmetModelsGlobal.Services;

namespace GestmetModelsClient
{
    public class UtilisateurRepository : IRepositoryGlobalConnect<Utilisateur>
    {

        IRepositoryGlobalConnect<G.Utilisateur> _globalService;
        public UtilisateurRepository()
        {
            _globalService = new GS.UtilisateurRepository();
        }
        public int Create(Utilisateur T)
        {
            return _globalService.Create(T.ToGlobalUtilisateur());
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

        public Utilisateur GetOne(int id)
        {
            return _globalService.GetOne(id)?.ToClientUtilisateur();
        }

        public void Update(int id, Utilisateur T)
        {
            _globalService.Update(id, T.ToGlobalUtilisateur());
        }
        public Utilisateur GetConnect(Utilisateur T)
        {
            return _globalService.GetConnect(T.ToGlobalUtilisateur()).ToClientUtilisateur();
        }

    }    
}
