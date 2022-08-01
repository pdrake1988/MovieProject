using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Cast
    {
        public int Id { get; set; }

        [Column(TypeName = "Varchar(128)")]
        public string Name { get; set; }

        [Column(TypeName = "Varchar(MAX)")]
        public string Gender { get; set; }

        [Column(TypeName = "Varchar(MAX)")]
        public string TmdbUrl { get; set; }

        [Column(TypeName = "Varchar(2084)")]
        public string ProfilePath { get; set; }
    }
}
