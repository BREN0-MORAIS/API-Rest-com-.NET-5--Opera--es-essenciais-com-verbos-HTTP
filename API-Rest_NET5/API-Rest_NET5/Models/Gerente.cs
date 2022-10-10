
using FilmesAPI.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API_Rest_NET5.Models
{
    public class Gerente
    {
        [Key]
 
        public int Id { get; set; }
        public string  Nome { get; set; }


        public virtual IEnumerable<Cinema> Cinemas { get; set; }
    }
}
