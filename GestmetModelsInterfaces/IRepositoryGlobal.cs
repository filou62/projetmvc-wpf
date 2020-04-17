using System;
using System.Collections.Generic;

namespace GestmetModelsInterfaces
{
    public interface IRepositoryGlobal<TEntity>
    {
        TEntity GetOne(int id);
        IEnumerable<TEntity> GetAll();
        int Create(TEntity T);
        void Delete(int id);
        void Update(int id, TEntity T);
        Boolean CreateNew(TEntity T);
        
    }
}
