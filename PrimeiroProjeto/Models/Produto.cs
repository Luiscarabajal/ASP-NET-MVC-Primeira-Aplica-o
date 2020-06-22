using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrimeiroProjeto.Models
{
    public class Produto
    {
        public long? ProdutoId { get; set; }
        public string Nome { get; set; }
        public long? CategoriaId { get; set; }//chave estrangeira e pode ser null '?'
        public long? FabricanteId { get; set; } //idem
        public Categoria Categoria { get; set; }
        public Fabricante Fabricante { get; set; }
    }
}