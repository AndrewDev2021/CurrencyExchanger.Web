﻿using System.ComponentModel.DataAnnotations;

namespace CurrencyExсhanger.Web.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string Password { get; set; }
    }
}