using GestmetModelsInterfaces;
using UIGestmetModelsClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ToolBox.MVVM;
using UIGestmetModelsClient.Services;
using GestmetWpf.Models;

namespace GestmetWpf.ViewModels
{
    public class UtilisateurViewModel : BindableBase
    {
        private string email;
        public string Email
        {
            get { return email; }
            set { email = value;RaisePropertyChanged(); }
        }
        private string login;
        public string Login
        {
            get { return login; }
            set { login = value; RaisePropertyChanged(); }
        }
        private string motpasse;
        public string MotPasse
        {
            get { return motpasse; }
            set { motpasse = value; RaisePropertyChanged(); }
        }
        private int personnelid;
        public int PersonnelId
        {
            get { return personnelid; }
            set { personnelid = value; RaisePropertyChanged(); }
        }
        private bool estactif;
        public bool EstActif
        {
            get { return estactif; }
            set { estactif = value; RaisePropertyChanged(); }
        }








        private IRepositoryGlobalConnect<UIGestmetModelsClient.Utilisateur> _serviceutil;
        private ObservableCollection<Models.Utilisateur> utilisateurlist;
        public ObservableCollection<Models.Utilisateur> UtilisateurList
        {
            get { return utilisateurlist; }
            set { utilisateurlist = value;RaisePropertyChanged(); }
        }
        public RelayCommand AddCommand { get; set; }
        public RelayCommand<Models.Utilisateur> RemoveCommand { get; set; }
        public UtilisateurViewModel()
        {
            _serviceutil = new UtilisateurRepository();
            UtilisateurList = new ObservableCollection<Models.Utilisateur>(_serviceutil.GetAll().Select(u => new Models.Utilisateur
            {
                Id = u.Id,
                Email = u.Email,
                Login = u.Login,
                MotPasse = u.MotPasse,
                PersonnelId = u.PersonnelId,
                EstActif = u.EstActif
            }));
            AddCommand = new RelayCommand(AddUtilisateur);
            RemoveCommand = new RelayCommand<Models.Utilisateur>(RemoveUtilisateur);
        }
        private void RemoveUtilisateur(Models.Utilisateur param)
        {
            UtilisateurList.Remove(param);
            _serviceutil = new UtilisateurRepository();
            _serviceutil.Delete(param.Id);
        }
        private void AddUtilisateur()
        {
            Models.Utilisateur u = new Models.Utilisateur();
            u.Email = email;
            u.Login = login;
            u.MotPasse = motpasse;
            u.PersonnelId = personnelid;
            u.EstActif = estactif;

            _serviceutil = new UtilisateurRepository();
            _serviceutil.Create(new UIGestmetModelsClient.Utilisateur(u.Email, u.Login, u.MotPasse, u.PersonnelId, u.EstActif));
            

        }

    }
}
