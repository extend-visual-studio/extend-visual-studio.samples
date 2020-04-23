using System;
using System.ComponentModel.Composition;
using MonoDevelop.Ide;

namespace ManagedExtensibilityFrameworkRegistration
{
    [PartCreationPolicy(CreationPolicy.Shared)] // Singleton part.
    [Export(typeof(ISampleService))]
    class SampleService : ISampleService
    {
        private readonly IConfiguration configuration;

        [ImportingConstructor]
        public SampleService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public void DoWork()
        {
            MessageService.ShowMessage(configuration.Message);
        }
    }
}