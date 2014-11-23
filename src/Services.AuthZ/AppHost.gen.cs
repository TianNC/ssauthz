﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Reflection;
using Common.Services;
using Common.Storage;
using Funq;
using Services.AuthZ.Storage;
using Services.AuthZ.Storage.DataEntities;
using Services.AuthZ.Workflow;
using Services.DataContracts;
using ServiceStack.FluentValidation;
using ServiceStack.Validation;

namespace Services.AuthZ
{
    /// <summary>
    /// A host environment for all web services of this project.
    /// </summary>
    internal partial class AppHost : AppHostBase { }

    internal abstract class AppHostBase : ServiceStack.AppHostBase
    {
        private const string ServiceDisplayName = @"Services.AuthZ Service";
        public static readonly Assembly[] DiscoveryAssemblies = new[]
        {
            typeof(AppHost).Assembly,
            typeof(ServiceInterfaces).Assembly,
        };

        /// <summary>
        /// Creates a new instance of the <see ref="AppHostBase" /> class.
        /// </summary>
        public AppHostBase()
            : base(ServiceDisplayName, DiscoveryAssemblies)
        {
        }

        /// <summary>
        /// Configures the service host environment
        /// </summary>
        public override void Configure(Container container)
        {
            this.SetJsonConfig();

            // Add plug-ins
            this.PreventUnsecuredHttpAccess();
            Plugins.Add(new ValidationFeature());

            // Auto wire-up any validators (those derived from <see cref="AbstractValidator{T}"/>)
            container.RegisterValidators(DiscoveryAssemblies);
            RegisterCustomValidators(container);

            // Register generated classes
            RegisterStorageProviders(container);
            RegisterWorkflowManagers(container);

            RegisterCustomTypes(container);
        }

        /// <summary>
        /// Registers any custom validator types (that are not derived from <see cref="AbstractValidator{T}"/>)
        /// </summary>
        protected virtual void RegisterCustomValidators(Container container) { }

        /// <summary>
        /// Registers all storage providers types
        /// </summary>
        protected virtual void RegisterStorageProviders(Container container)
        {
            container.RegisterAutoWiredAs<ClientApplicationEntityStore, IStoreContext<ClientApplicationEntity>>();
            container.RegisterAutoWiredAs<UserAccountEntityStore, IStoreContext<UserAccountEntity>>();

            container.RegisterAutoWiredAs<ClientApplicationStorageProvider, IStorageProvider<IClientApplication>>();
            container.RegisterAutoWiredAs<UserAccountStorageProvider, IStorageProvider<IUserAccount>>();
        }

        /// <summary>
        /// Registers all workflow manager types (auto-wired)
        /// </summary>
        protected virtual void RegisterWorkflowManagers(Container container)
        {
            container.RegisterAutoWiredAs<AccessTokensManager, IAccessTokensManager>();
            container.RegisterAutoWiredAs<ClientApplicationsManager, IClientApplicationsManager>();
            container.RegisterAutoWiredAs<UserAccountsManager, IUserAccountsManager>();
        }

        /// <summary>
        /// Registers all other dependency injected types
        /// </summary>
        protected virtual void RegisterCustomTypes(Container container) { }

    }
}