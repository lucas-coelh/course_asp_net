﻿using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Endereco
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]

        public string Logradouro { get; set; }
        [Required]
        public string Bairro { get; set; }
        [Required]
        public string Numero { get; set; }



    }
}
