using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class MovieGenre
    {
        public int Id { get; set; }
        public Movie MovieId { get; set; }
        public Genre GenreId { get; set; }
    }
}
