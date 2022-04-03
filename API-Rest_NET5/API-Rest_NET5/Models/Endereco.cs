using System.ComponentModel.DataAnnotations;

namespace API_Rest_NET5.Models
{
    public class Endereco
    {

        [Key]
        [Required]
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
    }
}
