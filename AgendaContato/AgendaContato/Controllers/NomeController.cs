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

            return RedirectToAction("Index", "Nome");
        }
    }
}