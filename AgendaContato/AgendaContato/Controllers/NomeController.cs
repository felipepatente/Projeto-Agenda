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
            if (ModelState.IsValid)
            {
                NomeDAO dao = new NomeDAO();
                dao.Adiciona(nome);                
            }
            
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
            return View(nomes);
        }
        
        public ActionResult CampoInvalido()
        {
            return View();
        }

        [Route("Listar/{id}", Name="ExcluirNome")]
        public ActionResult Excluir(int id = 0)
        {
            if (id != 0)
            {
                using (var contexto = new AgendaContext())
                {
                    var nomes = contexto.Nomes.Where(n => n.Id == id);

                    foreach (Nome item in nomes)
                    {
                        contexto.Nomes.Remove(item);                        
                    }

                    contexto.SaveChanges();
                }
            }

            return RedirectToAction("Menu", "Nome");
        }
    }
}