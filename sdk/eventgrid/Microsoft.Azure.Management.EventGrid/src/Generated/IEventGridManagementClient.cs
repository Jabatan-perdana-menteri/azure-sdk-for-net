// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventGrid
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// Azure EventGrid Management Client
    /// </summary>
    public partial interface IEventGridManagementClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// Subscription credentials that uniquely identify a Microsoft Azure
        /// subscription. The subscription ID forms part of the URI for every
        /// service call.
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// Version of the API to be used with the client request.
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default
        /// value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When
        /// set to true a unique x-ms-client-request-id value is generated and
        /// included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IChannelsOperations.
        /// </summary>
        IChannelsOperations Channels { get; }

        /// <summary>
        /// Gets the IDomainsOperations.
        /// </summary>
        IDomainsOperations Domains { get; }

        /// <summary>
        /// Gets the IDomainTopicsOperations.
        /// </summary>
        IDomainTopicsOperations DomainTopics { get; }

        /// <summary>
        /// Gets the IEventChannelsOperations.
        /// </summary>
        IEventChannelsOperations EventChannels { get; }

        /// <summary>
        /// Gets the IEventSubscriptionsOperations.
        /// </summary>
        IEventSubscriptionsOperations EventSubscriptions { get; }

        /// <summary>
        /// Gets the IDomainTopicEventSubscriptionsOperations.
        /// </summary>
        IDomainTopicEventSubscriptionsOperations DomainTopicEventSubscriptions { get; }

        /// <summary>
        /// Gets the ITopicEventSubscriptionsOperations.
        /// </summary>
        ITopicEventSubscriptionsOperations TopicEventSubscriptions { get; }

        /// <summary>
        /// Gets the IDomainEventSubscriptionsOperations.
        /// </summary>
        IDomainEventSubscriptionsOperations DomainEventSubscriptions { get; }

        /// <summary>
        /// Gets the ISystemTopicEventSubscriptionsOperations.
        /// </summary>
        ISystemTopicEventSubscriptionsOperations SystemTopicEventSubscriptions { get; }

        /// <summary>
        /// Gets the IPartnerTopicEventSubscriptionsOperations.
        /// </summary>
        IPartnerTopicEventSubscriptionsOperations PartnerTopicEventSubscriptions { get; }

        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        IOperations Operations { get; }

        /// <summary>
        /// Gets the IPartnerConfigurationsOperations.
        /// </summary>
        IPartnerConfigurationsOperations PartnerConfigurations { get; }

        /// <summary>
        /// Gets the IPartnerDestinationsOperations.
        /// </summary>
        IPartnerDestinationsOperations PartnerDestinations { get; }

        /// <summary>
        /// Gets the IPartnerNamespacesOperations.
        /// </summary>
        IPartnerNamespacesOperations PartnerNamespaces { get; }

        /// <summary>
        /// Gets the IPartnerRegistrationsOperations.
        /// </summary>
        IPartnerRegistrationsOperations PartnerRegistrations { get; }

        /// <summary>
        /// Gets the IPartnerTopicsOperations.
        /// </summary>
        IPartnerTopicsOperations PartnerTopics { get; }

        /// <summary>
        /// Gets the IPrivateEndpointConnectionsOperations.
        /// </summary>
        IPrivateEndpointConnectionsOperations PrivateEndpointConnections { get; }

        /// <summary>
        /// Gets the IPrivateLinkResourcesOperations.
        /// </summary>
        IPrivateLinkResourcesOperations PrivateLinkResources { get; }

        /// <summary>
        /// Gets the ISystemTopicsOperations.
        /// </summary>
        ISystemTopicsOperations SystemTopics { get; }

        /// <summary>
        /// Gets the ITopicsOperations.
        /// </summary>
        ITopicsOperations Topics { get; }

        /// <summary>
        /// Gets the IExtensionTopicsOperations.
        /// </summary>
        IExtensionTopicsOperations ExtensionTopics { get; }

        /// <summary>
        /// Gets the ITopicTypesOperations.
        /// </summary>
        ITopicTypesOperations TopicTypes { get; }

        /// <summary>
        /// Gets the IVerifiedPartnersOperations.
        /// </summary>
        IVerifiedPartnersOperations VerifiedPartners { get; }

    }
}
