using Microsoft.SqlServer.Dac;
using Microsoft.SqlServer.Dac.Model;
using System.Management.Automation;

namespace PsDac
{
    [Cmdlet(VerbsLifecycle.Install, "Package")]
    [OutputType(typeof(DacPackage))]
    public class InstallPackageCommand : PSCmdlet
    {
        [Parameter(
            Position = 0,
            Mandatory = true,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        [ValidateNotNullOrEmpty()]
        public DacPackage Package { get; set; }

        [Parameter()]
        public DacServices Service { get; set; } = ConnectServiceCommand.Service;

        [Parameter()]
        public string DatabaseName { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            Service.Deploy(package: Package, targetDatabaseName: DatabaseName);
        }
    }
}
