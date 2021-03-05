using CRMPrj_ACMESearch = CRMPrj.ACMESearch;

using CRMPrj_CRM = CRMPrj.CRM;

using System;

namespace CRMPrj.Project
{
// Project-8D8DDA51F9DEA2F
/// <summary>
/// OpenSpan project.
/// </summary>
[OpenSpan.Design.TargetEnvironmentAttribute(OpenSpan.Design.TargetEnvironment.Driver)]
[OpenSpan.Design.ComponentIdentityAttribute("Project-8D8DDA51F9DEA2F")]
[OpenSpan.Design.DeploymentVersionAttribute("1.0")]
[OpenSpan.Design.ProjectDescriptorAttribute(OpenSpan.Design.ProjectDescriptorType.Present)]
[OpenSpan.Design.ProjectDescriptorAttribute(OpenSpan.Design.ProjectDescriptorType.ContainsAdapters)]
public sealed class CRMPrj : OpenSpan.Runtime.RuntimeProject
{
	
	public CRMPrj() : 
			base()
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.CRMPrj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public CRMPrj(System.ComponentModel.ISynchronizeInvoke syncObject) : 
			base(syncObject)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.CRMPrj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public CRMPrj(System.IServiceProvider serviceProvider) : 
			base(serviceProvider)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.CRMPrj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public CRMPrj(bool initializeScout) : 
			base(initializeScout)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.CRMPrj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	private CRMPrj(System.IServiceProvider serviceProvider, OpenSpan.Runtime.RuntimeHostCommandLineHelper commandLineHelper, OpenSpan.Deployment.DeploymentManifest deploymentManifest) : 
			base(serviceProvider, commandLineHelper, deploymentManifest)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.CRMPrj_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	private void CRMPrj_Initialize()
	{
		this.mId = new OpenSpan.Design.ComponentIdentity("Project-8D8DDA51F9DEA2F");
		this.mVersion = new System.Version("19.1.75.0");
		this.mDeploymentVersion = "1.0";
		this.mTransformationVersion = new System.Version("19.1.0.25");
		this.mTargetEnvironment = OpenSpan.Design.TargetEnvironment.Driver;
	}
	
	// WebAdapter-8D8DE2BB139348E
	public CRMPrj_ACMESearch ACMESearch
	{
		get
		{
			return ((CRMPrj_ACMESearch)(this["ACMESearch"]));
		}
	}
	
	// WindowsAdapter-8D8DFE68142AF1E
	public CRMPrj_CRM CRM
	{
		get
		{
			return ((CRMPrj_CRM)(this["CRM"]));
		}
	}
}

}

