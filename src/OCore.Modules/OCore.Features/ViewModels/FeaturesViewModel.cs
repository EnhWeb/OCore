using System;
using System.Collections.Generic;
using OCore.Features.Models;
using OCore.Environment.Extensions;

namespace OCore.Features.ViewModels 
{
    public class FeaturesViewModel 
    {
        public IEnumerable<ModuleFeature> Features { get; set; }
        public FeaturesBulkAction BulkAction { get; set; }
        public Func<IExtensionInfo, bool> IsAllowed { get; set; }
    }

    public enum FeaturesBulkAction 
    {
        None,
        Enable,
        Disable,
        Update,
        Toggle
    }
}