using AgendaContato.DAO;
using AgendaContato.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgendaContato.Controllers
{
    public class NomeController : Controller
    {
        // GET: Nome
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Adiciona(Nome nome)
        {
            NomeDAO dao = new NomeDAO();
            dao.Adiciona(nome);

            return RedirectToAction("Menu", "Nome");
        }

        public ActionResult Menu()
        {
            return View();
        }

        public ActionResult Listar()
        {
            NomeDAO dao = new NomeDAO();
            IList<Nome> nomes = dao.Lista();
            ViewBag.Nomes = nomes;
            return View();
        }

    }
}