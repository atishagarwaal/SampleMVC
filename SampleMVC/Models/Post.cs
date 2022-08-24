using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleMVC.Models
{
    public class Post
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [MaxLength(1000)]
        public string Content { get; set; }

        [DataType(DataType.Text)]
        public string Author { get; set; }

        [DataType(DataType.Date)]
        public DateTime Posted { get; set; }
    }
}
