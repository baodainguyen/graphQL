using System.Collections.Generic;
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

        public ICollection<Command> Commands { get; set; } = new List<Command>();
    }

    public class Command
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string HowTo { get; set; }

        [Required]
        public string CommandLine { get; set; }

        [Required]
        public int PlatformId { get; set; }

        public Platform Platform { get; set; }
    }
}