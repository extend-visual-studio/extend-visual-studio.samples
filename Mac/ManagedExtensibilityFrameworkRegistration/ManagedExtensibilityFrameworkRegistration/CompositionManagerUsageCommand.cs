using System;
using MonoDevelop.Components.Commands;
using MonoDevelop.Ide.Composition;
using ManagedExtensibilityFrameworkRegistration;

namespace ManagedExtensibilityFrameworkRegistration
{
    public class CompositionManagerUsageCommand : CommandHandler
    {
        // Example: Getting a lazily loaded export.
        readonly Lazy<ISampleService> sampleService = CompositionManager.GetExport<ISampleService>();
        public ISampleService SampleService => sampleService.Value;

        protected override void Run()
        {
            // Example: Getting the 
            var service = CompositionManager.Instance.ExportProvider.GetExportedValue<ISampleService>();

            service.DoWork();
        }
    }
}
