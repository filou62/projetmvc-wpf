using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestmetModelsInterfaces
{
    public interface IRepositoryGlobalConnect<TEntity>
    {
        TEntity GetOne(int id);
        IEnumerable<TEntity> GetAll();
        int Create(TEntity T);
        void Delete(int id);
        void Update(int id, TEntity T);
        Boolean CreateNew(TEntity T);
        TEntity GetConnect(TEntity T);
    }
}
