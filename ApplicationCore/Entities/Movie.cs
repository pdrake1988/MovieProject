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

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Budget { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Revenue { get; set; }

        [Column(TypeName = "Varchar(2084)")]
        public string? ImdbUrl { get; set; }

        [Column(TypeName = "Varchar(2084)")]
        public string? TmdbUrl { get; set; }

        [Column(TypeName = "Varchar(2084)")]
        public string PosterUrl { get; set; }

        [Column(TypeName = "Varchar(2084)")]
        public string? BackdropUrl { get; set; }

        [Column(TypeName = "Varchar(64)")]
        public string? OriginalLanguage { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int RunTime { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        public decimal Price { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        [Column(TypeName = "Varchar(200)")]
        public string? UpdatedBy { get; set; }

        [Column(TypeName = "Varchar(200)")]
        public string? CreatedBy { get; set; }

        public List<Crew> MovieCrew { get; set; }

        public List<Genre> MovieGenres { get; set; }

        public List<Cast> MovieCast { get; set; }

        public List<Review> MovieReviews { get; set; }

        public List<Trailer> MovieTrailers { get; set; }

        public List<Purchase> Purchases { get; set; }

        public List<Favorite> Favourites { get; set; }
    }
}
