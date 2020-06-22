using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrimeiroProjeto.Models
{
    public class Fabricante
    {
        public long FabricanteId { get; set; }
        public String Nome { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}