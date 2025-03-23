using OrchardCore.ContentManagement.Handlers;
using System.Threading.Tasks;
using TryOrchard.Cms.Models;

namespace TryOrchard.Cms.Handlers
{
    public class MyTestPartHandler : ContentPartHandler<MyTestPart>
    {
        public override Task InitializingAsync(InitializingContentContext context, MyTestPart part)
        {
            part.Show = true;

            return Task.CompletedTask;
        }
    }
}