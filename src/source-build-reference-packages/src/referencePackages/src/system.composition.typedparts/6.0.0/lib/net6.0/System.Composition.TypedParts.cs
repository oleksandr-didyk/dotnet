// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// ------------------------------------------------------------------------------
// Changes to this file must follow the http://aka.ms/api-review process.
// ------------------------------------------------------------------------------
[assembly: System.Runtime.CompilerServices.CompilationRelaxations(8)]
[assembly: System.Runtime.CompilerServices.RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: System.Diagnostics.Debuggable(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: System.Runtime.Versioning.TargetFramework(".NETCoreApp,Version=v6.0", FrameworkDisplayName = "")]
[assembly: System.CLSCompliant(true)]
[assembly: System.Reflection.AssemblyDefaultAlias("System.Composition.TypedParts")]
[assembly: System.Resources.NeutralResourcesLanguage("en-US")]
[assembly: System.Reflection.AssemblyMetadata(".NETFrameworkAssembly", "")]
[assembly: System.Reflection.AssemblyMetadata("Serviceable", "True")]
[assembly: System.Reflection.AssemblyMetadata("PreferInbox", "True")]
[assembly: System.Reflection.AssemblyCompany("Microsoft Corporation")]
[assembly: System.Reflection.AssemblyCopyright("© Microsoft Corporation. All rights reserved.")]
[assembly: System.Reflection.AssemblyDescription("Provides some extension methods for the Managed Extensibility Framework.\r\n\r\nCommonly Used Types:\r\nSystem.Composition.CompositionContextExtensions\r\nSystem.Composition.Hosting.ContainerConfiguration")]
[assembly: System.Reflection.AssemblyFileVersion("6.0.21.52210")]
[assembly: System.Reflection.AssemblyInformationalVersion("6.0.0+4822e3c3aa77eb82b2fb33c9321f923cf11ddde6")]
[assembly: System.Reflection.AssemblyProduct("Microsoft® .NET")]
[assembly: System.Reflection.AssemblyTitle("System.Composition.TypedParts")]
[assembly: System.Reflection.AssemblyMetadata("RepositoryUrl", "https://github.com/dotnet/runtime")]
[assembly: System.Reflection.AssemblyVersionAttribute("6.0.0.0")]
[assembly: System.Runtime.CompilerServices.ReferenceAssembly]
[assembly: System.Reflection.AssemblyFlagsAttribute((System.Reflection.AssemblyNameFlags)0x70)]
namespace System.Composition
{
    public static partial class CompositionContextExtensions
    {
        public static void SatisfyImports(this CompositionContext compositionContext, object objectWithLooseImports, Convention.AttributedModelProvider conventions) { }

        public static void SatisfyImports(this CompositionContext compositionContext, object objectWithLooseImports) { }
    }
}

namespace System.Composition.Hosting
{
    public partial class ContainerConfiguration
    {
        public ContainerConfiguration() { }

        public CompositionHost CreateContainer() { throw null; }

        public ContainerConfiguration WithAssemblies(Collections.Generic.IEnumerable<Reflection.Assembly> assemblies, Convention.AttributedModelProvider conventions) { throw null; }

        public ContainerConfiguration WithAssemblies(Collections.Generic.IEnumerable<Reflection.Assembly> assemblies) { throw null; }

        public ContainerConfiguration WithAssembly(Reflection.Assembly assembly, Convention.AttributedModelProvider conventions) { throw null; }

        public ContainerConfiguration WithAssembly(Reflection.Assembly assembly) { throw null; }

        public ContainerConfiguration WithDefaultConventions(Convention.AttributedModelProvider conventions) { throw null; }

        public ContainerConfiguration WithPart(Type partType, Convention.AttributedModelProvider conventions) { throw null; }

        public ContainerConfiguration WithPart(Type partType) { throw null; }

        public ContainerConfiguration WithPart<TPart>() { throw null; }

        public ContainerConfiguration WithPart<TPart>(Convention.AttributedModelProvider conventions) { throw null; }

        public ContainerConfiguration WithParts(Collections.Generic.IEnumerable<Type> partTypes, Convention.AttributedModelProvider conventions) { throw null; }

        public ContainerConfiguration WithParts(Collections.Generic.IEnumerable<Type> partTypes) { throw null; }

        public ContainerConfiguration WithParts(params Type[] partTypes) { throw null; }

        public ContainerConfiguration WithProvider(Core.ExportDescriptorProvider exportDescriptorProvider) { throw null; }
    }
}