using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "Varchar(256)")]
        public string Title { get; set; }

        [Column(TypeName = "Varchar(200)")]
        public string Overview { get; set; }

        [Column(TypeName = "Varchar(512)")]
        public string Tagline { get; set; }

        public decimal Budget { get; set; }

        public decimal Revenue { get; set; }

        [Column(TypeName = "Varchar(2084)")]
        public string ImdbUrl { get; set; }

        [Column(TypeName = "Varchar(2084)")]
        public string TmdbUrl { get; set; }

        [Column(TypeName = "Varchar(2084)")]
        public string PosterUrl { get; set; }

        [Column(TypeName = "Varchar(2084)")]
        public string BackdropUrl { get; set; }

        [Column(TypeName = "Varchar(64)")]
        public string OriginalLanguage { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int RunTime { get; set; }

        public decimal Price { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        [Column(TypeName = "Varchar(200)")]
        public string UpdatedBy { get; set; }

        [Column(TypeName = "Varchar(200)")]
        public string CreatedBy { get; set; }
    }
}
