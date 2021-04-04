﻿namespace BookList.App.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Author { get; set; }

        public string ISBN { get; set; }
    }
}
