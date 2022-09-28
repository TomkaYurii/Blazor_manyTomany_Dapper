using System.ComponentModel.DataAnnotations;

namespace Blazor_manyTomany_Dapper.Entitites
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Phone { get; set; }
    }
}
