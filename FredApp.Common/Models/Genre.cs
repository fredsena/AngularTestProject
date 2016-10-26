
using Dapper;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FredApp.Common.Models
{
    [Table("Genre")]
    [DataContract]
    public class Genre
    {
        [Key]
        [DataMember]
        public virtual int GenreId { get; set; }

        [DataMember]
        public virtual string Name { get; set; }

        [DataMember]
        public virtual string Description { get; set; }

        [IgnoreInsert]
        [IgnoreUpdate]
        public virtual IEnumerable<Album> Album { get; set; }
    }
}
