using GestmetAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestmetAsp.Utils
{
    public static class SessionManager
    {
        public static Utilisateur SessionUser
        {
            get { return (Utilisateur)HttpContext.Current.Session["SessionUser"]; }
            set { HttpContext.Current.Session["SessionUser"] = value; }
        }
    }
}