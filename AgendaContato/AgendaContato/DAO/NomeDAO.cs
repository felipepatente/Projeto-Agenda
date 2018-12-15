using AgendaContato.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgendaContato.DAO
{
    public class NomeDAO
    {
        public void Adiciona(Nome nome)
        {
            using (var context = new AgendaContext())
            {
                context.Nomes.Add(nome);
                context.SaveChanges();
            }
        }

        public IList<Nome> Lista()
        {
            using (var contexto = new AgendaContext())
            {
                return contexto.Nomes.ToList();
            }
        }

        public Nome BuscaPorId(int id)
        {
            using (var contexto = new AgendaContext())
            {
                return contexto.Nomes.Find(id);
            }
        }

        public void Atualiza(Nome nome)
        {
            using (var contexto = new AgendaContext())
            {
                contexto.Entry(nome).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();                
            }
        }
    }
}