using System;

namespace ValidandoDataeMoeda.Models
{
    public class Produto
    {
        public string Nome { get; set; }
        public DateTime Validade { get; set; }
        public decimal Valor { get; set; }
    }
}