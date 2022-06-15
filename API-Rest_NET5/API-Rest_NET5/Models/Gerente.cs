ss
using FilmesAPI.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API_Rest_NET5.Models
{
    public class Gerente
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string  Nome { get; set; }
        public virtual IEnumerable<Cinema> Cinemas { get; set; }
    }
}
