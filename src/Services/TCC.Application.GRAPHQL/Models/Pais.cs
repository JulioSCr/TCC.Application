using System;
using System.ComponentModel.DataAnnotations;

namespace TCC.Application.GRAPHQL.Models
{
    public class Pais
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Gentilico { get; set; }

        [Required]
        public string NomePais { get; set; }

        [Required]
        public string NomePaisInternacional { get; set; }

        [Required]
        public string Sigla { get; set; }
    }
}
