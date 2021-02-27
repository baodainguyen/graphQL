using System.Linq;
using GraphQL.Data;
using GraphQL.Models;
using HotChocolate;
using HotChocolate.Types;

namespace GraphQL.Queries
{
    public record AddPlatformPayload(Platform platform);

    public record AddPlatformInput(string Name);

    public class PlatformType: ObjectType<Platform> {
        protected override void Configure(IObjectTypeDescriptor<Platform> descriptor)
        {
            //descriptor.Description("Can add here instead of Entity in Models.cs")
            descriptor.Field(p => p.LicenseKey).Ignore();
            descriptor
                .Field(p => p.Commands)
                .ResolveWith<Resolvers>(p => p.GetCommands(default!, default!))
                .UseDbContext<AppDbContext>()
                .Description("This is the list available commands for this platform");
        }

        private class Resolvers
        {
            public IQueryable<Command> GetCommands(Platform platform, [ScopedService] AppDbContext context)
            {
                return context.Commands.Where(p => p.PlatformId == platform.Id);
            }
        }
    }
}