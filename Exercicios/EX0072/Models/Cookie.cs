using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EX0072.Models
{
    public class Cookie
    {
        [Key]
        public int JogoId {get; set;}
        public string Nome {get; set;}
        public string Descricao {get; set;}
        public string imagem {get; set;}
        public bool Ativo {get; set;}
    }
}