using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HotChocolate;

namespace GraphQL.Models
{
    [GraphQLDescription("Represents any software or service that has a command line interface.")]
    public class Platform
    {
        [Key]
        public int Id { get; set; }
        
        [Required]  // can not be null
        public string Name { get; set; }

        [GraphQLDescription("Represents a purchased, valid license for platform")]
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