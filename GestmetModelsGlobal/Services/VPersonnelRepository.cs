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
   public class VPersonnelRepository : IRepositoryGlobal<Personnel>
    {
        private const string ConnectionString = @"Data Source=PHILIPPEPRO\SQLEXPRESS;Initial Catalog=DBGESTMETWEB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private Connection _dbConnection;

        public VPersonnelRepository()
        {
            _dbConnection = new Connection(ConnectionString);
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
            Command command = new Command("SELECT * FROM [dbo].[V_PersonnelActif];");
            return _dbConnection.ExecuteReader(command, (dr) => dr.ToVPersonnel());
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
