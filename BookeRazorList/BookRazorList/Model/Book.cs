using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookRazorList.Model
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nome do Livro")]
        public string Name { get; set; }

        public string ISBN { get; set; }

        [Display(Name = "Autor")]
        public string Author { get; set; }
    }
}
