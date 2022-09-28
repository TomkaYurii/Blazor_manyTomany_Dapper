using System.ComponentModel.DataAnnotations;

namespace Blazor_manyTomany_Dapper.Entitites
{
    public class Publisher
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
