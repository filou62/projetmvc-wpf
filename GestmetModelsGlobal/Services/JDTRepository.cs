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
    public class JDTRepository : IRepositoryGlobal<JournalDesTravaux>
    {
        private const string ConnectionString = @"Data Source=PHILIPPEPRO\SQLEXPRESS;Initial Catalog=DBGESTMETWEB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private Connection _dbConnection;

        public JDTRepository()
        {
            _dbConnection = new Connection(ConnectionString);
        }
        public int Create(JournalDesTravaux entity)
        {
            Command command = new Command("SP_AddJDT",true);
            command.AddParameter("@PersonnelId", entity.PersonnelId);
            command.AddParameter("@PosteId", entity.PosteId);
            command.AddParameter("@DateChantier", entity.DateChantier);
            command.AddParameter("@HeuresProd", entity.HeuresProd);
            command.AddParameter("@VoitPerso", entity.VoitPerso);
            command.AddParameter("@ZoneDepl", entity.ZoneDepl);
            command.AddParameter("@ChefChantierId", entity.ChefChantierId);
            command.AddParameter("@Login", entity.Login);

            return _dbConnection.ExecuteNonQuery(command);

        }

        public bool CreateNew(JournalDesTravaux entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            Command command = new Command("SP_DeleteJDT", true);
            command.AddParameter("@JDTId", id);
            _dbConnection.ExecuteNonQuery(command);
        }

        public IEnumerable<JournalDesTravaux> GetAll()
        {
            Command command = new Command("SELECT * FROM [dbo].[JournalDesTravaux];");
            
            return _dbConnection.ExecuteReader(command,(dr)=>dr.ToJDT());
        }

        public JournalDesTravaux GetOne(int id)
        {
            Command command = new Command("SELECT * FROM [dbo].[JournalDesTravaux] WHERE JDTId = @JDTId ;");
            command.AddParameter("@JDTId", id);
           return  _dbConnection.ExecuteReader(command, (dr) => dr.ToJDT()).SingleOrDefault();
        }

        public void Update(int id, JournalDesTravaux entity)
        {
            Command command = new Command("SP_UpdateJDT", true);
            command.AddParameter("@JDTId", id);
            command.AddParameter("@PersonnelId", entity.PersonnelId);
            command.AddParameter("@PosteId", entity.PosteId);
            command.AddParameter("@DateChantier", entity.DateChantier);
            command.AddParameter("@HeuresProd", entity.HeuresProd);
            command.AddParameter("@VoitPerso", entity.VoitPerso);
            command.AddParameter("@ZoneDepl", entity.ZoneDepl);
            command.AddParameter("@ChefChantierId", entity.ChefChantierId);
            command.AddParameter("@Login", entity.Login);
            command.AddParameter("@EstVAlide", entity.EstValide);
            _dbConnection.ExecuteNonQuery(command); 
        }
    }
}
