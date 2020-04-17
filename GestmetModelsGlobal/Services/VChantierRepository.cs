using GestmetModelsGlobal.Mappers;
using GestmetModelsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Connections;

namespace GestmetModelsGlobal.Services
{
    public class VChantierRepository : IRepositoryGlobal<VChantier>
    {
        private const string ConnectionString = @"Data Source=PHILIPPEPRO\SQLEXPRESS;Initial Catalog=DBGESTMETWEB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private Connection _dbConnection;

        public VChantierRepository()
        {
            _dbConnection = new Connection(ConnectionString);
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
                       Command command = new Command("SELECT * FROM [dbo].[V_ChantierActif];");
            return _dbConnection.ExecuteReader(command, (dr) => dr.ToVChantier()); 
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
