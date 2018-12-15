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

            return RedirectToAction("Menu", "Email");
        }

        public ActionResult Menu()
        {
            return View();
        }

        public ActionResult ListarEmail()
        {
            EmailDAO dao = new EmailDAO();
            IList<Email> emails = dao.Lista();            
            return View(emails);
        }

        [Route("ListarEmail/{id}", Name = "ExcluirEmail")]
        public ActionResult Excluir(int id = 0)
        {
            if (id != 0)
            {
                using (var contexto = new AgendaContext())
                {
                    var emails = contexto.Emails.Where(n => n.Id == id);

                    foreach (Email item in emails)
                    {
                        contexto.Emails.Remove(item);
                    }

                    contexto.SaveChanges();
                }
            }

            return RedirectToAction("Menu", "Telefone");
        }
    }
}
