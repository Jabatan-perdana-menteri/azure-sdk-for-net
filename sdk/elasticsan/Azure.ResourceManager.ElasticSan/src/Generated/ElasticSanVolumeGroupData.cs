// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ElasticSan.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ElasticSan
{
    /// <summary> A class representing the ElasticSanVolumeGroup data model. </summary>
    public partial class ElasticSanVolumeGroupData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of ElasticSanVolumeGroupData. </summary>
        /// <param name="location"> The location. </param>
        public ElasticSanVolumeGroupData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of ElasticSanVolumeGroupData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> State of the operation on the resource. </param>
        /// <param name="protocolType"> Type of storage target. </param>
        /// <param name="encryption"> Type of encryption. </param>
        /// <param name="networkAcls"> A collection of rules governing the accessibility from specific network locations. </param>
        internal ElasticSanVolumeGroupData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ProvisioningState? provisioningState, StorageTargetType? protocolType, EncryptionType? encryption, NetworkRuleSet networkAcls) : base(id, name, resourceType, systemData, tags, location)
        {
            ProvisioningState = provisioningState;
            ProtocolType = protocolType;
            Encryption = encryption;
            NetworkAcls = networkAcls;
        }

        /// <summary> State of the operation on the resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> Type of storage target. </summary>
        public StorageTargetType? ProtocolType { get; set; }
        /// <summary> Type of encryption. </summary>
        public EncryptionType? Encryption { get; set; }
        /// <summary> A collection of rules governing the accessibility from specific network locations. </summary>
        internal NetworkRuleSet NetworkAcls { get; set; }
        /// <summary> The list of virtual network rules. </summary>
        public IList<VirtualNetworkRule> VirtualNetworkRules
        {
            get
            {
                if (NetworkAcls is null)
                    NetworkAcls = new NetworkRuleSet();
                return NetworkAcls.VirtualNetworkRules;
            }
        }
    }
}
