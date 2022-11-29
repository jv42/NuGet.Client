// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Build", "CA1031:Modify 'InitializeTypes' to catch a more specific allowed exception type, or rethrow the exception.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.ExtensionManagerShim.InitializeTypes(System.Action{System.String})")]
[assembly: SuppressMessage("Build", "CA1031:Modify 'CreateMetadata' to catch a more specific allowed exception type, or rethrow the exception.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.PackageManagementHelpers.CreateMetadata(System.String,NuGet.Packaging.Core.PackageIdentity)~NuGet.VisualStudio.IVsPackageMetadata")]
[assembly: SuppressMessage("Build", "CA1822:Member CopyNativeBinaries does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.PreinstalledPackageInstaller.CopyNativeBinaries(NuGet.PackageManagement.VisualStudio.VsMSBuildProjectSystem,System.String,System.String)")]
[assembly: SuppressMessage("Build", "CA1822:Member GetExtensionRepositoryPath does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.PreinstalledPackageInstaller.GetExtensionRepositoryPath(System.String,System.Object,System.Action{System.String})~System.String")]
[assembly: SuppressMessage("Build", "CA1822:Member GetRegistryRepositoryPath does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.PreinstalledPackageInstaller.GetRegistryRepositoryPath(System.String,System.Collections.Generic.IEnumerable{NuGet.VisualStudio.IRegistryKey},System.Action{System.String})~System.String")]
[assembly: SuppressMessage("Build", "CA1801:Parameter provider of method AddFromExtension is never used. Remove the parameter or use it in the method body.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.PreinstalledRepositoryProvider.AddFromExtension(NuGet.Protocol.Core.Types.ISourceRepositoryProvider,System.String)")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object)' could vary based on the current user's locale settings. Replace this call in 'PreinstalledRepositoryProvider.GetExtensionRepositoryPath(string)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.PreinstalledRepositoryProvider.GetExtensionRepositoryPath(System.String)~System.String")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object, object)' could vary based on the current user's locale settings. Replace this call in 'PreinstalledRepositoryProvider.GetRegistryRepositoryPath(string)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.PreinstalledRepositoryProvider.GetRegistryRepositoryPath(System.String)~System.String")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object)' could vary based on the current user's locale settings. Replace this call in 'VsFrameworkCompatibility.GetFrameworksSupportingNetStandard(FrameworkName)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.VsFrameworkCompatibility.GetFrameworksSupportingNetStandard(System.Runtime.Versioning.FrameworkName)~System.Collections.Generic.IEnumerable{System.Runtime.Versioning.FrameworkName}")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object)' could vary based on the current user's locale settings. Replace this call in 'VsPackageInstaller.GetSource(string)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.VsPackageInstaller.GetSource(System.String)~NuGet.Protocol.Core.Types.SourceRepository")]
[assembly: SuppressMessage("Build", "CA1822:Member InstallInternalCoreAsync does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.VsPackageInstaller.InstallInternalCoreAsync(NuGet.PackageManagement.NuGetPackageManager,NuGet.PackageManagement.GatherCache,NuGet.ProjectManagement.NuGetProject,NuGet.Packaging.Core.PackageIdentity,System.Collections.Generic.IEnumerable{NuGet.Protocol.Core.Types.SourceRepository},NuGet.VisualStudio.VSAPIProjectContext,System.Boolean,System.Boolean,System.Threading.CancellationToken)~System.Threading.Tasks.Task")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'VsPackageInstallerEvents.VsPackageInstallerEvents(IPackageEventsProvider eventProvider)', validate parameter 'eventProvider' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.VsPackageInstallerEvents.#ctor(NuGet.ProjectManagement.IPackageEventsProvider)")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'VsPackageInstallerProjectEvents.VsPackageInstallerProjectEvents(IPackageProjectEventsProvider eventProvider)', validate parameter 'eventProvider' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.VsPackageInstallerProjectEvents.#ctor(NuGet.PackageManagement.IPackageProjectEventsProvider)")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'bool VsPackageInstallerServices.IsPackageInstalled(Project project, string packageId, SemanticVersion version)', validate parameter 'version' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.VsPackageInstallerServices.IsPackageInstalled(EnvDTE.Project,System.String,NuGet.SemanticVersion)~System.Boolean")]
[assembly: SuppressMessage("Build", "CA1031:Modify 'RestorePackages' to catch a more specific allowed exception type, or rethrow the exception.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.VsPackageRestorer.RestorePackages(EnvDTE.Project)")]
[assembly: SuppressMessage("Build", "CA1822:Member GetProjectsInSolutionAsync does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.VsPathContextProvider.GetProjectsInSolutionAsync(EnvDTE.DTE)~System.Threading.Tasks.Task{System.Collections.Generic.IEnumerable{EnvDTE.Project}}")]
[assembly: SuppressMessage("Build", "CA1031:Modify 'MigrateProjectToPackageRefAsync' to catch a more specific allowed exception type, or rethrow the exception.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.VsProjectJsonToPackageReferenceMigrator.MigrateProjectToPackageRefAsync(System.String)~System.Threading.Tasks.Task{System.Object}")]
[assembly: SuppressMessage("Build", "CA1822:Member RunDesignTimeBuildAsync does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.VisualStudio.VsTemplateWizard.RunDesignTimeBuildAsync(EnvDTE.Project)")]
