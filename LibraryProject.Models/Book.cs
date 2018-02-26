using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Models
{
    public class Book
    {
        [Key, ForeignKey("BookLoan")]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
        public string YearPublished { get; set; }
        public bool IsAvailable { get; set; }
        
        public virtual BookLoan BookLoan { get; set; }
    }
}
