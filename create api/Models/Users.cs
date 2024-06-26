using System.ComponentModel.DataAnnotations;

namespace create_api.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; } 
        public string phoneNo { get; set; }
    }
}
