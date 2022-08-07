using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        [Column(TypeName = "decimal(3, 2)")]
        public decimal Rating { get; set; }
        [Column(TypeName = "Varchar(2000)")]
        public string ReviewText { get; set; }
    }
}
