using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Model
{
    public class ReviewModel
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        [Required]
        public decimal Rating { get; set; }
        [Required]
        public string ReviewText { get; set; }
    }
}
