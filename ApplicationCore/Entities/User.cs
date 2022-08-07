using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class User
    {
        public int Id { get; set; }

        [Column(TypeName = "Varchar(128)")]
        public string FirstName { get; set; }

        [Column(TypeName = "Varchar(128)")]
        public string LastName { get; set; }

        [Column(TypeName = "datetime2(7)")]
        public DateTime DateOfBirth { get; set; }

        [Column(TypeName = "Varchar(256)")]
        public string Email { get; set; }

        [Column(TypeName = "Varchar(1024)")]
        public string HashedPassword { get; set; }

        [Column(TypeName = "Varchar(1024)")]
        public string Salt { get; set; }

        [Column(TypeName = "Varchar(16)")]
        public string PhoneNumber { get; set; }

        [Column(TypeName = "datetime2(7)")]
        public DateTime LockoutEndDate { get; set; }

        [Column(TypeName = "datetime2(7)")]
        public DateTime LastLoginDateTime { get; set; }

        public bool IsLocked { get; set; }

        public int AccessFailedCount { get; set; }

        public List<Review> Reviews { get; set; }

        public List<Purchase> Purchases { get; set; }

        public List<Role> Roles { get; set; }

        public List<Favorite> Favorites { get; set; }
    }
}
