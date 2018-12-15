using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgendaContato.Models
{
    public class Telefone
    {
        public int Id { get; set; }

        [Phone, Required]
        public String Numero { get; set; }

        public int NomeId { get; set; }

        public Nome NomeContato { get; set; }
    }
}