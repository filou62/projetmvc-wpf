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
    public class UtilisateurRepository : IRepositoryGlobalConnect<Utilisateur>
    {
        private const string ConnectionString = @"Data Source=PHILIPPEPRO\SQLEXPRESS;Initial Catalog=DBGESTMETWEB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private Connection _dbConnection;

        public UtilisateurRepository()
        {
            _dbConnection = new Connection(ConnectionString);
        }
        public int Create(Utilisateur entity)
        {
            Command command = new Command("SP_AddUtilisateur", true);
            command.AddParameter("@Email", entity.Email);
            command.AddParameter("@Login", entity.Login);
            command.AddParameter("@MotPasse", entity.MotPasse);
            command.AddParameter("@PersonnelId", entity.PersonnelId);
           // command.AddParameter("@EstActif", entity.EstActif);
            return _dbConnection.ExecuteNonQuery(command);

        }

        public bool CreateNew(Utilisateur T)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            Command command = new Command("SP_DeleteUtilisateur", true);
            command.AddParameter("@UtilisateurId", id);
            _dbConnection.ExecuteNonQuery(command);
        }

        public IEnumerable<Utilisateur> GetAll()
        {
            Command command = new Command("SELECT * FROM [dbo].[Utilisateur];");
            return _dbConnection.ExecuteReader(command, (dr) => dr.ToUtilisateur());
        }

        public Utilisateur GetOne(int id)
        {
            Command command = new Command("SELECT * FROM [dbo].[Utilisateur] WHERE UtilisateurId = @UtilisateurId;");
            command.AddParameter("@UtilisateurId", id);
            return _dbConnection.ExecuteReader(command, (dr) => dr.ToUtilisateur()).SingleOrDefault();
        }

        public void Update(int id, Utilisateur entity)
        {
            Command command = new Command("SP_UpdateUtilisateur", true);
            command.AddParameter("@UtilisateurId", id);
            command.AddParameter("@Email", entity.Email);
            command.AddParameter("@Login", entity.Login);
            command.AddParameter("@MotPasse", entity.MotPasse);
            command.AddParameter("@PersonnelId", entity.PersonnelId);
            command.AddParameter("@EstActif", entity.EstActif);
           _dbConnection.ExecuteNonQuery(command);
        }

        public Utilisateur GetConnect(Utilisateur entity)
        {
            Command command = new Command("SP_ConnectUtilisateur",true);
            command.AddParameter("@Login", entity.Login);
            command.AddParameter("@MotPasse", entity.MotPasse);
            Utilisateur utilisateur = _dbConnection.ExecuteReader(command, (dr) => dr.ToUtilisateur()).SingleOrDefault();
            if (utilisateur is null)
                return new Utilisateur();
            return utilisateur;
            
        }
    }
}
