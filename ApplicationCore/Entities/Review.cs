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
        public Movie MovieId { get; set; }
        public User UserId { get; set; }
        public decimal Rating { get; set; }
        [Column(TypeName = "Varchar(MAX)")]
        public string ReviewText { get; set; }
    }
}
