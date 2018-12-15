using AgendaContato.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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

        public void Atualiza(Email email)
        {
            using (var contexto = new AgendaContext())
            {
                //try
                //{
                    contexto.Entry(email).State = System.Data.Entity.EntityState.Modified;
                    contexto.SaveChanges();
                //}
                //catch (DbEntityValidationException e)
                //{
                //    foreach (var eve in e.EntityValidationErrors)
                //    {
                //        System.Diagnostics.Debug.WriteLine("Entidade do tipo \"{0}\" com estado \"{1}\" tem os seguintes erros de validação:",
                //            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                //        foreach (var ve in eve.ValidationErrors)
                //        {
                //            System.Diagnostics.Debug.WriteLine("- Propriedade: \"{0}\", Error: \"{1}\"",
                //                ve.PropertyName, ve.ErrorMessage);
                //        }
                //    }
                    
                //}
                
            }
        }
    }
}