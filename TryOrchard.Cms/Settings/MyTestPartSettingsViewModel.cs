using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace TryOrchard.Cms.Settings
{
    public class MyTestPartSettingsViewModel
    {
        public string MySetting { get; set; }

        [BindNever]
        public MyTestPartSettings MyTestPartSettings { get; set; }
    }
}
