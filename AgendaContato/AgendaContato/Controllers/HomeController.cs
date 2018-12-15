using AgendaContato.DAO;
using AgendaContato.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgendaContato.Controllers
{
    public class HomeController : Controller
    {        
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult FiltrarDados()
        {
            return View();            
        }

        public ActionResult Listar(string nome)
        {
            HomeDAO dao = new HomeDAO();
            IList<Nome> nomes = dao.Lista(nome);
            return View(nomes);
        }
    }
}