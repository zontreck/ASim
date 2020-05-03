﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Mono.Addins;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("ZSim.Region.CoreModules")]
[assembly: AssemblyDescription("Core modules for OpenSim")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("ZSim.Region.CoreModules.Properties")]
[assembly: AssemblyCopyright("Copyright ©  2012")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("94f62dd1-bcf3-4218-9844-9a3996286e3e")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
[assembly: AssemblyVersion(ZSim.VersionInfo.AssemblyVersionNumber)]


[assembly: Addin("ZSim.Region.CoreModules", ZSim.VersionInfo.VersionNumber)]
[assembly: AddinDependency("ZSim.Region.Framework", ZSim.VersionInfo.VersionNumber)]

