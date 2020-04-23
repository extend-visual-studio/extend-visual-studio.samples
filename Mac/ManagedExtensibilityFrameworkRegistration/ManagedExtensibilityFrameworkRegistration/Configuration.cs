using System;
using System.ComponentModel.Composition;

namespace ManagedExtensibilityFrameworkRegistration
{
    [PartCreationPolicy(CreationPolicy.NonShared)] // Multi-instance part; a new instance will be created each time the part is used as a dependency
    [Export(typeof(IConfiguration))]
    public class Configuration : IConfiguration
    {
        public string Message => "Hello World!";
    }
}