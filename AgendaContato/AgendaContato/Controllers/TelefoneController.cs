﻿using AgendaContato.DAO;
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
            TelefoneDAO dao = new TelefoneDAO();
            dao.Adiciona(telefone);

            return RedirectToAction("Index", "Telefone");
        }
    }
}