using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Models
{
    public class BookLoan : BaseModel
    {
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime DateRented { get; set; }
        public DateTime ReturnByDate { get; set; }

        public virtual Book Book { get; set; }
        public virtual User User { get; set; }
    }
}
