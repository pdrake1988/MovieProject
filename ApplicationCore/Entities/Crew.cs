using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Crew
    {
        public int Id { get; set; }

        [Column(TypeName = "Varchar(128)")]
        public string Name { get; set; }

        [Column(TypeName = "Varchar(6)")]
        public string Gender { get; set; }

        [Column(TypeName = "Varchar(200)")]
        public string TmdbUrl { get; set; }

        [Column(TypeName = "Varchar(2084)")]
        public string ProfilePath { get; set; }
    }
}
