using AgendaContato.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgendaContato.DAO
{
    public class HomeDAO
    {
        public IList<Nome> Lista(String nome)
        {
            using (var contexto = new AgendaContext())
            {                
                return contexto.Nomes.Where(p => p.NomeContato.Contains(nome)).ToList();
            }
        }
    }
}