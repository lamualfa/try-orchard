using Fluid;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentManagement.Handlers;
using OrchardCore.ContentTypes.Editors;
using OrchardCore.Data.Migration;
using TryOrchard.Cms.Drivers;
using TryOrchard.Cms.Handlers;
using TryOrchard.Cms.Models;
using TryOrchard.Cms.Settings;
using TryOrchard.Cms.ViewModels;
using OrchardCore.Modules;

namespace TryOrchard.Cms;

public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.Configure<TemplateOptions>(o =>
        {
            o.MemberAccessStrategy.Register<MyTestPartViewModel>();
        });

        services.AddContentPart<MyTestPart>()
            .UseDisplayDriver<MyTestPartDisplayDriver>()
            .AddHandler<MyTestPartHandler>();

        services.AddScoped<IContentTypePartDefinitionDisplayDriver, MyTestPartSettingsDisplayDriver>();
        services.AddDataMigration<Migrations>();
    }

    public override void Configure(IApplicationBuilder builder, IEndpointRouteBuilder routes, IServiceProvider serviceProvider)
    {
        routes.MapAreaControllerRoute(
            name: "Home",
            areaName: "TryOrchard.Cms",
            pattern: "Home/Index",
            defaults: new { controller = "Home", action = "Index" }
        );
    }
}

