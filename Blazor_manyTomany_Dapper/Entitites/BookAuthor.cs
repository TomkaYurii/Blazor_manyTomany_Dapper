using System.ComponentModel.DataAnnotations;

namespace Blazor_manyTomany_Dapper.Entitites
{
    public class BookAuthor
    {
        [Key]
        public long ISBN { get; set; }
        public int AuthorId { get; set; }
        public byte? AuthorOrd { get; set; }
    }
}
