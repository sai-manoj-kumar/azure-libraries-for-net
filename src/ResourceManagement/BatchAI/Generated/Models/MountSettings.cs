// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.BatchAI.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Details of the File Server.
    /// </summary>
    public partial class MountSettings
    {
        /// <summary>
        /// Initializes a new instance of the MountSettings class.
        /// </summary>
        public MountSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MountSettings class.
        /// </summary>
        /// <param name="mountPoint">Path where the NFS is mounted on the
        /// Server.</param>
        /// <param name="fileServerPublicIP">Public IP of the File Server
        /// VM.</param>
        /// <param name="fileServerInternalIP">Internal subnet IP which can be
        /// used to access the file Server from within the subnet.</param>
        /// <param name="fileServerType">Type of the fileserver e.g. nfs,
        /// glusterfs etc.</param>
        public MountSettings(string mountPoint = default(string), string fileServerPublicIP = default(string), string fileServerInternalIP = default(string), string fileServerType = default(string))
        {
            MountPoint = mountPoint;
            FileServerPublicIP = fileServerPublicIP;
            FileServerInternalIP = fileServerInternalIP;
            FileServerType = fileServerType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets path where the NFS is mounted on the Server.
        /// </summary>
        [JsonProperty(PropertyName = "mountPoint")]
        public string MountPoint { get; set; }

        /// <summary>
        /// Gets or sets public IP of the File Server VM.
        /// </summary>
        [JsonProperty(PropertyName = "fileServerPublicIP")]
        public string FileServerPublicIP { get; set; }

        /// <summary>
        /// Gets or sets internal subnet IP which can be used to access the
        /// file Server from within the subnet.
        /// </summary>
        [JsonProperty(PropertyName = "fileServerInternalIP")]
        public string FileServerInternalIP { get; set; }

        /// <summary>
        /// Gets or sets type of the fileserver e.g. nfs, glusterfs etc.
        /// </summary>
        /// <remarks>
        /// Possible values include: 'nfs', 'glusterfs'
        /// </remarks>
        [JsonProperty(PropertyName = "fileServerType")]
        public string FileServerType { get; set; }

    }
}
