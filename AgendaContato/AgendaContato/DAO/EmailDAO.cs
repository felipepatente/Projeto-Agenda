using AgendaContato.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgendaContato.DAO
{
    public class EmailDAO
    {
        public void Adiciona(Email email)
        {
            using (var context = new AgendaContext())
            {
                context.Emails.Add(email);
                context.SaveChanges();
            }
        }

        public IList<Email> Lista()
        {
            using (var contexto = new AgendaContext())
            {
                return contexto.Emails.Include("NomeContato").ToList();
            }
        }

        public Email BuscaPorId(int id)
        {
            using (var contexto = new AgendaContext())
            {
                return contexto.Emails.Find(id);
            }
        }
    }
}