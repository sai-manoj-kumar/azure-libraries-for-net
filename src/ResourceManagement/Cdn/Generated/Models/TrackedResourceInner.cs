// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn.Fluent.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The resource model definition for a ARM tracked top level resource.
    /// </summary>
    public partial class TrackedResourceInner : Microsoft.Azure.Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the TrackedResourceInner class.
        /// </summary>
        public TrackedResourceInner()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TrackedResourceInner class.
        /// </summary>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        public TrackedResourceInner(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>))
            : base(location, id, name, type, tags)
        {
        }
    }
}
