using AgendaContato.DAO;
using AgendaContato.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgendaContato.Controllers
{
    public class EmailController : Controller
    {
        // GET: Email
        public ActionResult Index()
        {
            NomeDAO nomeDao = new NomeDAO();
            IList<Nome> nomes = nomeDao.Lista();
            ViewBag.Nomes = nomes;
            return View();
        }

        [HttpPost]
        public ActionResult Adiciona(Email email)
        {
            EmailDAO dao = new EmailDAO();
            dao.Adiciona(email);

            return RedirectToAction("Index", "Email");
        }
    }
}