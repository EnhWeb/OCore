using System.Collections.Generic;
using OCore.Environment.Extensions.Features;

namespace OCore.Features.Models 
{
    /// <summary>
    /// Represents a module's feature.
    /// </summary>
    public class ModuleFeature 
    {
        /// <summary>
        /// The feature descriptor.
        /// </summary>
        public IFeatureInfo Descriptor  { get; set; }

        /// <summary>
        /// Boolean value indicating if the feature is enabled.
        /// </summary>
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Boolean value indicating if the feature needs a data update / migration.
        /// </summary>
        public bool NeedsUpdate { get; set; }

        /// <summary>
        /// Boolean value indicating if the module needs a version update.
        /// </summary>
        public bool NeedsVersionUpdate { get; set; }

        /// <summary>
        /// Boolean value indicating if the feature was recently installed.
        /// </summary>
        public bool IsRecentlyInstalled { get; set; }

        /// <summary>
        /// List of features that depend on this feature.
        /// </summary>
        public IEnumerable<IFeatureInfo> DependentFeatures { get; set; }

        /// <summary>
        /// List of features that this feature depends on.
        /// </summary>
        public IEnumerable<IFeatureInfo> FeatureDependencies { get; set; }
    }
}