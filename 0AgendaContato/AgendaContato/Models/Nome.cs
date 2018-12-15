using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgendaContato.Models
{
    public class Nome
    {
        public int Id { get; set; }

        [Required]
        public String NomeContato { get; set; }
    }
}