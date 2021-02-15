using System.ComponentModel.DataAnnotations;

namespace GraphQL.Models
{
    public class Platform
    {
        [Key]
        public int Id { get; set; }
        
        [Required]  // can not be null
        public string Name { get; set; }
        

        public string LicenseKey { get; set; }
    }
}