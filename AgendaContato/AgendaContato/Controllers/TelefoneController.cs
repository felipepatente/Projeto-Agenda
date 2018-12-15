using AgendaContato.DAO;
using AgendaContato.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgendaContato.Controllers
{
    public class TelefoneController : Controller
    {
        // GET: Telefone
        public ActionResult Index()
        {
            NomeDAO nomeDao = new NomeDAO();
            IList<Nome> nomes = nomeDao.Lista();
            ViewBag.Nomes = nomes;
            return View();
        }

        [HttpPost]
        public ActionResult Adiciona(Telefone telefone)
        {
            if (ModelState.IsValid)
            {
                TelefoneDAO dao = new TelefoneDAO();
                dao.Adiciona(telefone);
            }

            return RedirectToAction("Menu", "Telefone");
        }

        public ActionResult Menu()
        {
            return View();
        }

        public ActionResult ListarTelefone()
        {
            TelefoneDAO dao = new TelefoneDAO();
            IList<Telefone> telefones = dao.Lista();           
            return View(telefones);
        }

        [Route("ListarTelefone/{id}", Name = "ExcluirTelefone")]
        public ActionResult Excluir(int id = 0)
        {
            if (id != 0)
            {
                using (var contexto = new AgendaContext())
                {
                    var telefones = contexto.Telefones.Where(t => t.Id == id);

                    foreach (Telefone item in telefones)
                    {
                        contexto.Telefones.Remove(item);
                    }

                    contexto.SaveChanges();
                }
            }

            return RedirectToAction("Menu", "Telefone");
        }
    }
}