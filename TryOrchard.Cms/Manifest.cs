using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "TryOrchard.Cms",
    Author = "The Orchard Core Team",
    Website = "https://orchardcore.net",
    Version = "0.0.1",
    Description = "TryOrchard.Cms",
    Dependencies = new[] { "OrchardCore.Contents" },
    Category = "Content Management"
)]
