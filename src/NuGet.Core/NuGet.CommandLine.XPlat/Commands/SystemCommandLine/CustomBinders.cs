// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

// Do not manually edit this autogenerated file:
// instead modify the neighboring .tt file (text template) and/or NuGet.CommandLine.Xplat\Commands\SystemCommandLine\Commands.xml (data file),
// then re-execute the text template via "run custom tool" on VS context menu for .tt file, or via dotnet-t4 global tool.

using System.CommandLine;
using System.CommandLine.Binding;
using NuGet.Commands;

namespace NuGet.CommandLine.XPlat.Commands
{
    /// <summary>Generated with CustomBinders.tt</summary>
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.VisualStudio.TextTemplating.VSHost.TextTemplatingService", null)]
    internal partial class AddSourceCustomBinder : BinderBase<AddSourceArgs>
    {
        private readonly Argument<string> _source;
        private readonly Option<string> _name;
        private readonly Option<string> _username;
        private readonly Option<string> _password;
        private readonly Option<bool> _storePasswordInClearText;
        private readonly Option<string> _validAuthenticationTypes;
        private readonly Option<string> _configfile;

        public AddSourceCustomBinder(Argument<string> source, Option<string> name, Option<string> username, Option<string> password, Option<bool> storePasswordInClearText, Option<string> validAuthenticationTypes, Option<string> configfile)
        {
            _source = source;
            _name = name;
            _username = username;
            _password = password;
            _storePasswordInClearText = storePasswordInClearText;
            _validAuthenticationTypes = validAuthenticationTypes;
            _configfile = configfile;
        }

        protected override AddSourceArgs GetBoundValue(BindingContext bindingContext)
        {
            var returnValue = new AddSourceArgs()
            {
                Source = bindingContext.ParseResult.GetValueForArgument(_source),
                Name = bindingContext.ParseResult.GetValueForOption(_name),
                Username = bindingContext.ParseResult.GetValueForOption(_username),
                Password = bindingContext.ParseResult.GetValueForOption(_password),
                StorePasswordInClearText = bindingContext.ParseResult.GetValueForOption(_storePasswordInClearText),
                ValidAuthenticationTypes = bindingContext.ParseResult.GetValueForOption(_validAuthenticationTypes),
                Configfile = bindingContext.ParseResult.GetValueForOption(_configfile),
            };
            return returnValue;
        } // end GetBoundValue method
    } // end class

    /// <summary>Generated with CustomBinders.tt</summary>
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.VisualStudio.TextTemplating.VSHost.TextTemplatingService", null)]
    internal partial class AddClientCertCustomBinder : BinderBase<AddClientCertArgs>
    {
        private readonly Option<string> _packageSource;
        private readonly Option<string> _path;
        private readonly Option<string> _password;
        private readonly Option<bool> _storePasswordInClearText;
        private readonly Option<string> _storeLocation;
        private readonly Option<string> _storeName;
        private readonly Option<string> _findBy;
        private readonly Option<string> _findValue;
        private readonly Option<bool> _force;
        private readonly Option<string> _configfile;

        public AddClientCertCustomBinder(Option<string> packageSource, Option<string> path, Option<string> password, Option<bool> storePasswordInClearText, Option<string> storeLocation, Option<string> storeName, Option<string> findBy, Option<string> findValue, Option<bool> force, Option<string> configfile)
        {
            _packageSource = packageSource;
            _path = path;
            _password = password;
            _storePasswordInClearText = storePasswordInClearText;
            _storeLocation = storeLocation;
            _storeName = storeName;
            _findBy = findBy;
            _findValue = findValue;
            _force = force;
            _configfile = configfile;
        }

        protected override AddClientCertArgs GetBoundValue(BindingContext bindingContext)
        {
            var returnValue = new AddClientCertArgs()
            {
                PackageSource = bindingContext.ParseResult.GetValueForOption(_packageSource),
                Path = bindingContext.ParseResult.GetValueForOption(_path),
                Password = bindingContext.ParseResult.GetValueForOption(_password),
                StorePasswordInClearText = bindingContext.ParseResult.GetValueForOption(_storePasswordInClearText),
                StoreLocation = bindingContext.ParseResult.GetValueForOption(_storeLocation),
                StoreName = bindingContext.ParseResult.GetValueForOption(_storeName),
                FindBy = bindingContext.ParseResult.GetValueForOption(_findBy),
                FindValue = bindingContext.ParseResult.GetValueForOption(_findValue),
                Force = bindingContext.ParseResult.GetValueForOption(_force),
                Configfile = bindingContext.ParseResult.GetValueForOption(_configfile),
            };
            return returnValue;
        } // end GetBoundValue method
    } // end class

    /// <summary>Generated with CustomBinders.tt</summary>
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.VisualStudio.TextTemplating.VSHost.TextTemplatingService", null)]
    internal partial class DisableSourceCustomBinder : BinderBase<DisableSourceArgs>
    {
        private readonly Argument<string> _name;
        private readonly Option<string> _configfile;

        public DisableSourceCustomBinder(Argument<string> name, Option<string> configfile)
        {
            _name = name;
            _configfile = configfile;
        }

        protected override DisableSourceArgs GetBoundValue(BindingContext bindingContext)
        {
            var returnValue = new DisableSourceArgs()
            {
                Name = bindingContext.ParseResult.GetValueForArgument(_name),
                Configfile = bindingContext.ParseResult.GetValueForOption(_configfile),
            };
            return returnValue;
        } // end GetBoundValue method
    } // end class

    /// <summary>Generated with CustomBinders.tt</summary>
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.VisualStudio.TextTemplating.VSHost.TextTemplatingService", null)]
    internal partial class EnableSourceCustomBinder : BinderBase<EnableSourceArgs>
    {
        private readonly Argument<string> _name;
        private readonly Option<string> _configfile;

        public EnableSourceCustomBinder(Argument<string> name, Option<string> configfile)
        {
            _name = name;
            _configfile = configfile;
        }

        protected override EnableSourceArgs GetBoundValue(BindingContext bindingContext)
        {
            var returnValue = new EnableSourceArgs()
            {
                Name = bindingContext.ParseResult.GetValueForArgument(_name),
                Configfile = bindingContext.ParseResult.GetValueForOption(_configfile),
            };
            return returnValue;
        } // end GetBoundValue method
    } // end class

    /// <summary>Generated with CustomBinders.tt</summary>
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.VisualStudio.TextTemplating.VSHost.TextTemplatingService", null)]
    internal partial class ListSourceCustomBinder : BinderBase<ListSourceArgs>
    {
        private readonly Option<string> _format;
        private readonly Option<string> _configfile;

        public ListSourceCustomBinder(Option<string> format, Option<string> configfile)
        {
            _format = format;
            _configfile = configfile;
        }

        protected override ListSourceArgs GetBoundValue(BindingContext bindingContext)
        {
            var returnValue = new ListSourceArgs()
            {
                Format = bindingContext.ParseResult.GetValueForOption(_format),
                Configfile = bindingContext.ParseResult.GetValueForOption(_configfile),
            };
            return returnValue;
        } // end GetBoundValue method
    } // end class

    /// <summary>Generated with CustomBinders.tt</summary>
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.VisualStudio.TextTemplating.VSHost.TextTemplatingService", null)]
    internal partial class RemoveSourceCustomBinder : BinderBase<RemoveSourceArgs>
    {
        private readonly Argument<string> _name;
        private readonly Option<string> _configfile;

        public RemoveSourceCustomBinder(Argument<string> name, Option<string> configfile)
        {
            _name = name;
            _configfile = configfile;
        }

        protected override RemoveSourceArgs GetBoundValue(BindingContext bindingContext)
        {
            var returnValue = new RemoveSourceArgs()
            {
                Name = bindingContext.ParseResult.GetValueForArgument(_name),
                Configfile = bindingContext.ParseResult.GetValueForOption(_configfile),
            };
            return returnValue;
        } // end GetBoundValue method
    } // end class

    /// <summary>Generated with CustomBinders.tt</summary>
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.VisualStudio.TextTemplating.VSHost.TextTemplatingService", null)]
    internal partial class UpdateSourceCustomBinder : BinderBase<UpdateSourceArgs>
    {
        private readonly Argument<string> _name;
        private readonly Option<string> _source;
        private readonly Option<string> _username;
        private readonly Option<string> _password;
        private readonly Option<bool> _storePasswordInClearText;
        private readonly Option<string> _validAuthenticationTypes;
        private readonly Option<string> _configfile;

        public UpdateSourceCustomBinder(Argument<string> name, Option<string> source, Option<string> username, Option<string> password, Option<bool> storePasswordInClearText, Option<string> validAuthenticationTypes, Option<string> configfile)
        {
            _name = name;
            _source = source;
            _username = username;
            _password = password;
            _storePasswordInClearText = storePasswordInClearText;
            _validAuthenticationTypes = validAuthenticationTypes;
            _configfile = configfile;
        }

        protected override UpdateSourceArgs GetBoundValue(BindingContext bindingContext)
        {
            var returnValue = new UpdateSourceArgs()
            {
                Name = bindingContext.ParseResult.GetValueForArgument(_name),
                Source = bindingContext.ParseResult.GetValueForOption(_source),
                Username = bindingContext.ParseResult.GetValueForOption(_username),
                Password = bindingContext.ParseResult.GetValueForOption(_password),
                StorePasswordInClearText = bindingContext.ParseResult.GetValueForOption(_storePasswordInClearText),
                ValidAuthenticationTypes = bindingContext.ParseResult.GetValueForOption(_validAuthenticationTypes),
                Configfile = bindingContext.ParseResult.GetValueForOption(_configfile),
            };
            return returnValue;
        } // end GetBoundValue method
    } // end class

    /// <summary>Generated with CustomBinders.tt</summary>
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.VisualStudio.TextTemplating.VSHost.TextTemplatingService", null)]
    internal partial class ConfigPathsCustomBinder : BinderBase<ConfigPathsArgs>
    {
        private readonly Argument<string> _workingDirectory;

        public ConfigPathsCustomBinder(Argument<string> workingDirectory)
        {
            _workingDirectory = workingDirectory;
        }

        protected override ConfigPathsArgs GetBoundValue(BindingContext bindingContext)
        {
            var returnValue = new ConfigPathsArgs()
            {
                WorkingDirectory = bindingContext.ParseResult.GetValueForArgument(_workingDirectory),
            };
            return returnValue;
        } // end GetBoundValue method
    } // end class

} // end namespace