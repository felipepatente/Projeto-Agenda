using AgendaContato.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgendaContato.DAO
{
    public class TelefoneDAO
    {
        public void Adiciona(Telefone telefone)
        {
            using (var context = new AgendaContext())
            {
                context.Telefones.Add(telefone);
                context.SaveChanges();
            }
        }

        public IList<Telefone> Lista()
        {
            using (var contexto = new AgendaContext())
            {
                return contexto.Telefones.Include("NomeContato").ToList();
            }
        }

        public Telefone BuscaPorId(int id)
        {
            using (var contexto = new AgendaContext())
            {
                return contexto.Telefones.Find(id);
            }
        }

        public void Atualiza(Telefone telefone)
        {
            using (var contexto = new AgendaContext())
            {
                contexto.Entry(telefone).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
    }
}