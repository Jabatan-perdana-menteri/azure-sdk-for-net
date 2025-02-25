// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary> A class representing the NetworkRuleSet data model. </summary>
    public partial class NetworkRuleSetData : ResourceData
    {
        /// <summary> Initializes a new instance of NetworkRuleSetData. </summary>
        public NetworkRuleSetData()
        {
            VirtualNetworkRules = new ChangeTrackingList<NetworkRuleSetVirtualNetworkRules>();
            IPRules = new ChangeTrackingList<NetworkRuleSetIPRules>();
        }

        /// <summary> Initializes a new instance of NetworkRuleSetData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="trustedServiceAccessEnabled"> Value that indicates whether Trusted Service Access is Enabled or not. </param>
        /// <param name="defaultAction"> Default Action for Network Rule Set. </param>
        /// <param name="virtualNetworkRules"> List VirtualNetwork Rules. </param>
        /// <param name="ipRules"> List of IpRules. </param>
        /// <param name="publicNetworkAccess"> This determines if traffic is allowed over public network. By default it is enabled. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        internal NetworkRuleSetData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, bool? trustedServiceAccessEnabled, DefaultAction? defaultAction, IList<NetworkRuleSetVirtualNetworkRules> virtualNetworkRules, IList<NetworkRuleSetIPRules> ipRules, PublicNetworkAccessFlag? publicNetworkAccess, AzureLocation? location) : base(id, name, resourceType, systemData)
        {
            TrustedServiceAccessEnabled = trustedServiceAccessEnabled;
            DefaultAction = defaultAction;
            VirtualNetworkRules = virtualNetworkRules;
            IPRules = ipRules;
            PublicNetworkAccess = publicNetworkAccess;
            Location = location;
        }

        /// <summary> Value that indicates whether Trusted Service Access is Enabled or not. </summary>
        public bool? TrustedServiceAccessEnabled { get; set; }
        /// <summary> Default Action for Network Rule Set. </summary>
        public DefaultAction? DefaultAction { get; set; }
        /// <summary> List VirtualNetwork Rules. </summary>
        public IList<NetworkRuleSetVirtualNetworkRules> VirtualNetworkRules { get; }
        /// <summary> List of IpRules. </summary>
        public IList<NetworkRuleSetIPRules> IPRules { get; }
        /// <summary> This determines if traffic is allowed over public network. By default it is enabled. </summary>
        public PublicNetworkAccessFlag? PublicNetworkAccess { get; set; }
        /// <summary> The geo-location where the resource lives. </summary>
        public AzureLocation? Location { get; }
    }
}
