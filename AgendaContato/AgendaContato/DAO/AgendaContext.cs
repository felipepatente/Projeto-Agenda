using AgendaContato.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AgendaContato.DAO
{
    public class AgendaContext : DbContext
    {
        public DbSet<Email> Emails { get; set; }

        public DbSet<Nome> Nomes { get; set; }

        public DbSet<Telefone> Telefones { get; set; }
        
    }
}