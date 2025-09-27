using System;
using System.ComponentModel.DataAnnotations;

namespace BlogApp.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public required string Title { get; set; }
        public string? Content { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
