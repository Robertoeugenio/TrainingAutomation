using System;

namespace CRMPrj
{
/// <summary>
/// OpenSpan design component.
/// </summary>
// WindowsAdapter-8D8DFE68142AF1E
[OpenSpan.Design.ComponentIdentityAttribute("WindowsAdapter-8D8DFE68142AF1E")]
[System.ComponentModel.ToolboxItemAttribute(false)]
public sealed class CRM : OpenSpan.Adapters.Windows.WindowsAdapter
{
	
	[OpenSpan.Design.ComponentIdentityAttribute("WindowsAdapter-8D8DFE68142AF1E\\DotNet20Factory-8D8DFE6930D8949")]
	public OpenSpan.Adapters.DotNet.DotNet20Factory DotNet20Factory;
	
	private OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule moduleNameMatchRule1;
	
	private OpenSpan.Adapters.Windows.MatchRules.ModuleVersionMatchRule moduleVersionMatchRule1;
	
	[OpenSpan.Design.ComponentIdentityAttribute("WindowsAdapter-8D8DFE68142AF1E\\ActiveXFactory-8D8DFE694190E2E")]
	public OpenSpan.Adapters.ActiveX.ActiveXFactory ActiveXFactory;
	
	private OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule moduleNameMatchRule2;
	
	public CRM()
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Setup field members
		// 
		System.ComponentModel.ComponentResourceManager _resources_ = new System.ComponentModel.ComponentResourceManager(typeof(CRM));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata2 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata3 = new OpenSpan.Adapters.TextMatchData();
		this.DotNet20Factory = new OpenSpan.Adapters.DotNet.DotNet20Factory();
		this.moduleNameMatchRule1 = new OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule();
		this.moduleVersionMatchRule1 = new OpenSpan.Adapters.Windows.MatchRules.ModuleVersionMatchRule();
		this.ActiveXFactory = new OpenSpan.Adapters.ActiveX.ActiveXFactory();
		this.moduleNameMatchRule2 = new OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule();
		// 
		// Initialize design component
		// 
		this.Initialize();
		// 
		// Set design component Id
		// 
		this.Id = new OpenSpan.Design.ComponentIdentity("WindowsAdapter-8D8DFE68142AF1E");
		// 
		// Set component Ids
		// 
		this.SetId(this.DotNet20Factory, new OpenSpan.Design.ComponentIdentity("DotNet20Factory-8D8DFE6930D8949"));
		this.SetId(this.moduleNameMatchRule1, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D8DFE69323E4E7"));
		this.SetId(this.moduleVersionMatchRule1, new OpenSpan.Design.ComponentIdentity("ModuleVersionMatchRule-8D8DFE6932D061C"));
		this.SetId(this.ActiveXFactory, new OpenSpan.Design.ComponentIdentity("ActiveXFactory-8D8DFE694190E2E"));
		this.SetId(this.moduleNameMatchRule2, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D8DFE694280D53"));
		// 
		// CRM
		// 
		this.AdvancedConfiguration = null;
		ComponentInfo.CodeDomData = _resources_.GetString("_CRM_1_");
		// 
		// DotNet20Factory
		// 
		this.DotNet20Factory.Extender = null;
		this.DotNet20Factory.FactoryName = null;
		this.DotNet20Factory.ForwardObjectExplorerEvent = true;
		this.DotNet20Factory.MatchingIndex = 0;
		// 
		// moduleNameMatchRule1
		// 
		textmatchdata1.Text = "mscorwks.dll";
		this.moduleNameMatchRule1.Text = textmatchdata1;
		// 
		// moduleVersionMatchRule1
		// 
		textmatchdata2.Mode = OpenSpan.Adapters.TextMatchMode.Wildcard;
		textmatchdata2.Text = "2.0.*.*";
		this.moduleVersionMatchRule1.Text = textmatchdata2;
		this.DotNet20Factory.MatchRules.Add(this.moduleNameMatchRule1);
		this.DotNet20Factory.MatchRules.Add(this.moduleVersionMatchRule1);
		this.DotNet20Factory.Name = "DotNet20Factory";
		this.DotNet20Factory.PegaId = 0;
		this.DotNet20Factory.TargetTypeString = "OpenSpan.Adapters.Windows.WindowsModule, OpenSpan.Adapters.Windows";
		this.DotNet20Factory.UseKeys = true;
		this.DotNet20Factory.XrayGuid = "";
		// 
		// ActiveXFactory
		// 
		this.ActiveXFactory.Extender = null;
		this.ActiveXFactory.FactoryName = null;
		this.ActiveXFactory.ForwardObjectExplorerEvent = true;
		this.ActiveXFactory.MatchingIndex = 0;
		// 
		// moduleNameMatchRule2
		// 
		textmatchdata3.Text = "ole32.dll";
		this.moduleNameMatchRule2.Text = textmatchdata3;
		this.ActiveXFactory.MatchRules.Add(this.moduleNameMatchRule2);
		this.ActiveXFactory.Name = "ActiveXFactory";
		this.ActiveXFactory.PegaId = 0;
		this.ActiveXFactory.TargetTypeString = "OpenSpan.Adapters.Windows.WindowsModule, OpenSpan.Adapters.Windows";
		this.ActiveXFactory.UseKeys = true;
		this.ActiveXFactory.XrayGuid = "";
		this.Controls.Add(this.DotNet20Factory);
		this.Controls.Add(this.ActiveXFactory);
		this.ExpressNativeTypes = null;
		this.Extender = null;
		this.FriendlyName = "CRM";
		this.Name = "CRM";
		this.Path = "C:\\Program Files (x86)\\Openspan\\CRM Setup\\CRM.exe";
		this.ReasonAdapterNotReady = null;
		this.StartMyDay = OpenSpan.ApplicationFramework.StartMyDay.StartOptions.None;
		this.StartMyDayControls = null;
		this.WorkingDirectory = "C:\\Program Files (x86)\\Openspan\\CRM Setup";
		this.XrayMasterNames = null;
		// 
		// Add components
		// 
		this.mComponents = new System.Collections.Generic.List<System.ComponentModel.IComponent>(20);
		this.Components.Add(this.DotNet20Factory);
		this.Components.Add(this.moduleNameMatchRule1);
		this.Components.Add(this.moduleVersionMatchRule1);
		this.Components.Add(this.ActiveXFactory);
		this.Components.Add(this.moduleNameMatchRule2);
	}
	
	private System.Collections.Generic.List<System.ComponentModel.IComponent> mComponents;
	
	public System.Collections.Generic.List<System.ComponentModel.IComponent> Components
	{
		get
		{
			return this.mComponents;
		}
	}
	
	/// <summary>
	/// Start design component.
	/// </summary>
	public override void Start()
	{
		base.Start();
	}
	
	/// <summary>
	/// Stop design component.
	/// </summary>
	public override void Stop()
	{
		base.Stop();
	}
	
	internal OpenSpan.Adapters.DotNet.DotNet20Factory Create_DotNet20Factory(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.DotNet.DotNet20Factory DotNet20Factory = new OpenSpan.Adapters.DotNet.DotNet20Factory();
		this.SetId(DotNet20Factory, new OpenSpan.Design.ComponentIdentity("DotNet20Factory-8D8DFE6930D8949"));
		DotNet20Factory.Extender = null;
		DotNet20Factory.FactoryName = null;
		DotNet20Factory.ForwardObjectExplorerEvent = true;
		DotNet20Factory.MatchingIndex = 0;
		OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule moduleNameMatchRule1;
		moduleNameMatchRule1 = new OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule();
		// 
		// moduleNameMatchRule1
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "mscorwks.dll";
		moduleNameMatchRule1.Text = textmatchdata1;
		OpenSpan.Adapters.Windows.MatchRules.ModuleVersionMatchRule moduleVersionMatchRule1;
		moduleVersionMatchRule1 = new OpenSpan.Adapters.Windows.MatchRules.ModuleVersionMatchRule();
		// 
		// moduleVersionMatchRule1
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata2 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata2.Mode = OpenSpan.Adapters.TextMatchMode.Wildcard;
		textmatchdata2.Text = "2.0.*.*";
		moduleVersionMatchRule1.Text = textmatchdata2;
		DotNet20Factory.MatchRules.Add(moduleNameMatchRule1);
		DotNet20Factory.MatchRules.Add(moduleVersionMatchRule1);
		DotNet20Factory.Name = "DotNet20Factory";
		DotNet20Factory.PegaId = 0;
		DotNet20Factory.TargetTypeString = "OpenSpan.Adapters.Windows.WindowsModule, OpenSpan.Adapters.Windows";
		DotNet20Factory.UseKeys = true;
		DotNet20Factory.XrayGuid = "";
		// 
		// Set designComp Ids
		// 
		this.SetId(moduleNameMatchRule1, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D8DFE69323E4E7"));
		this.SetId(moduleVersionMatchRule1, new OpenSpan.Design.ComponentIdentity("ModuleVersionMatchRule-8D8DFE6932D061C"));
		// 
		// Add components
		// 
		components.Add(moduleNameMatchRule1);
		components.Add(moduleVersionMatchRule1);
		// 
		// Result
		// 
		return DotNet20Factory;
	}
	
	internal OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule Create_moduleNameMatchRule1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule moduleNameMatchRule1 = new OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule();
		this.SetId(moduleNameMatchRule1, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D8DFE69323E4E7"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "mscorwks.dll";
		moduleNameMatchRule1.Text = textmatchdata1;
		// 
		// Result
		// 
		return moduleNameMatchRule1;
	}
	
	internal OpenSpan.Adapters.Windows.MatchRules.ModuleVersionMatchRule Create_moduleVersionMatchRule1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Windows.MatchRules.ModuleVersionMatchRule moduleVersionMatchRule1 = new OpenSpan.Adapters.Windows.MatchRules.ModuleVersionMatchRule();
		this.SetId(moduleVersionMatchRule1, new OpenSpan.Design.ComponentIdentity("ModuleVersionMatchRule-8D8DFE6932D061C"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Mode = OpenSpan.Adapters.TextMatchMode.Wildcard;
		textmatchdata1.Text = "2.0.*.*";
		moduleVersionMatchRule1.Text = textmatchdata1;
		// 
		// Result
		// 
		return moduleVersionMatchRule1;
	}
	
	internal OpenSpan.Adapters.ActiveX.ActiveXFactory Create_ActiveXFactory(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.ActiveX.ActiveXFactory ActiveXFactory = new OpenSpan.Adapters.ActiveX.ActiveXFactory();
		this.SetId(ActiveXFactory, new OpenSpan.Design.ComponentIdentity("ActiveXFactory-8D8DFE694190E2E"));
		ActiveXFactory.Extender = null;
		ActiveXFactory.FactoryName = null;
		ActiveXFactory.ForwardObjectExplorerEvent = true;
		ActiveXFactory.MatchingIndex = 0;
		OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule moduleNameMatchRule2;
		moduleNameMatchRule2 = new OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule();
		// 
		// moduleNameMatchRule2
		// 
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "ole32.dll";
		moduleNameMatchRule2.Text = textmatchdata1;
		ActiveXFactory.MatchRules.Add(moduleNameMatchRule2);
		ActiveXFactory.Name = "ActiveXFactory";
		ActiveXFactory.PegaId = 0;
		ActiveXFactory.TargetTypeString = "OpenSpan.Adapters.Windows.WindowsModule, OpenSpan.Adapters.Windows";
		ActiveXFactory.UseKeys = true;
		ActiveXFactory.XrayGuid = "";
		// 
		// Set designComp Ids
		// 
		this.SetId(moduleNameMatchRule2, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D8DFE694280D53"));
		// 
		// Add components
		// 
		components.Add(moduleNameMatchRule2);
		// 
		// Result
		// 
		return ActiveXFactory;
	}
	
	internal OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule Create_moduleNameMatchRule2(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule moduleNameMatchRule2 = new OpenSpan.Adapters.Windows.MatchRules.ModuleNameMatchRule();
		this.SetId(moduleNameMatchRule2, new OpenSpan.Design.ComponentIdentity("ModuleNameMatchRule-8D8DFE694280D53"));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "ole32.dll";
		moduleNameMatchRule2.Text = textmatchdata1;
		// 
		// Result
		// 
		return moduleNameMatchRule2;
	}
}

}

