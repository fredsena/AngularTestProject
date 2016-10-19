using Dapper;
using System.Collections.Generic;

namespace FredApp.Common.Models
{
    [Table("Artist")]
    public class Artist
    {
        [Key]
        public virtual int ArtistId { get; set; }
        public virtual string Name { get; set; }
        public virtual IEnumerable<Album> Album { get; set; }
    }
}
