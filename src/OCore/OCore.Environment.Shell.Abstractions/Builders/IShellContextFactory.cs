﻿using OCore.Environment.Shell.Descriptor.Models;
using OCore.Hosting.ShellBuilders;
using System.Threading.Tasks;

namespace OCore.Environment.Shell.Builders
{
    /// <summary>
    /// High-level coordinator that exercises other component capabilities to
    /// build all of the artifacts for a running shell given a tenant settings.
    /// </summary>
    public interface IShellContextFactory
    {
        /// <summary>
        /// Builds a shell context given a specific tenant settings structure
        /// </summary>
        Task<ShellContext> CreateShellContextAsync(ShellSettings settings);

        /// <summary>
        /// Builds a shell context for an uninitialized OCore instance. Needed
        /// to display setup user interface.
        /// </summary>
        Task<ShellContext> CreateSetupContextAsync(ShellSettings settings);

        /// <summary>
        /// Builds a shell context given a specific description of features and parameters.
        /// Shell's actual current descriptor has no effect. Does not use or update descriptor cache.
        /// </summary>
        Task<ShellContext> CreateDescribedContextAsync(ShellSettings settings, ShellDescriptor shellDescriptor);
    }
}
