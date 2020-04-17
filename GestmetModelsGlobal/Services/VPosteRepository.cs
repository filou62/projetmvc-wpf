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
    public class VPosteRepository : IRepositoryGlobal<VPoste>
    {
        private const string ConnectionString = @"Data Source=PHILIPPEPRO\SQLEXPRESS;Initial Catalog=DBGESTMETWEB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private Connection _dbConnection;

        public VPosteRepository()
        {
            _dbConnection = new Connection(ConnectionString);
        }
        public int Create(VPoste T)
        {
            throw new NotImplementedException();
        }

        public bool CreateNew(VPoste T)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VPoste> GetAll()
        {
            Command command = new Command("SELECT * FROM [dbo].[V_PosteActif];");
            return _dbConnection.ExecuteReader(command, (dr) => dr.ToVPoste());
        }

        public VPoste GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, VPoste T)
        {
            throw new NotImplementedException();
        }
    }
}
