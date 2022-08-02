using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Purchase
    {
        public int Id { get; set; }

        [Required]
        public int PurchaseNumber { get; set; }

        [Required]
        public decimal TotalPrice { get; set; }

        [Required]
        public decimal PurchaseDateTime { get; set; }

        public Movie MovieId { get; set; }
    }
}
