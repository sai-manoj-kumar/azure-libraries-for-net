// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a recommendation result generated by the recommendation
    /// engine.
    /// </summary>
    public partial class RecommendationInner
    {
        /// <summary>
        /// Initializes a new instance of the RecommendationInner class.
        /// </summary>
        public RecommendationInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RecommendationInner class.
        /// </summary>
        /// <param name="creationTime">Timestamp when this instance was
        /// created.</param>
        /// <param name="recommendationId">A GUID value that each
        /// recommendation object is associated with.</param>
        /// <param name="resourceId">Full ARM resource ID string that this
        /// recommendation object is associated with.</param>
        /// <param name="resourceScope">Name of a resource type this
        /// recommendation applies, e.g. Subscription, ServerFarm, Site.
        /// Possible values include: 'ServerFarm', 'Subscription',
        /// 'WebSite'</param>
        /// <param name="ruleName">Unique name of the rule.</param>
        /// <param name="displayName">UI friendly name of the rule (may not be
        /// unique).</param>
        /// <param name="message">Recommendation text.</param>
        /// <param name="level">Level indicating how critical this
        /// recommendation can impact. Possible values include: 'Critical',
        /// 'Warning', 'Information', 'NonUrgentSuggestion'</param>
        /// <param name="channels">List of channels that this recommendation
        /// can apply. Possible values include: 'Notification', 'Api', 'Email',
        /// 'Webhook', 'All'</param>
        /// <param name="tags">The list of category tags that this
        /// recommendation belongs to.</param>
        /// <param name="actionName">Name of action recommended by this
        /// object.</param>
        /// <param name="startTime">The beginning time in UTC of a range that
        /// the recommendation refers to.</param>
        /// <param name="endTime">The end time in UTC of a range that the
        /// recommendation refers to.</param>
        /// <param name="nextNotificationTime">When to notify this
        /// recommendation next in UTC. Null means that this will never be
        /// notified anymore.</param>
        /// <param name="notificationExpirationTime">Date and time in UTC when
        /// this notification expires.</param>
        /// <param name="notifiedTime">Last timestamp in UTC this instance was
        /// actually notified. Null means that this recommendation hasn't been
        /// notified yet.</param>
        /// <param name="score">A metric value measured by the rule.</param>
        /// <param name="isDynamic">True if this is associated with a
        /// dynamically added rule</param>
        /// <param name="extensionName">Extension name of the portal if
        /// exists.</param>
        /// <param name="bladeName">Deep link to a blade on the portal.</param>
        /// <param name="forwardLink">Forward link to an external document
        /// associated with the rule.</param>
        public RecommendationInner(System.DateTime? creationTime = default(System.DateTime?), System.Guid? recommendationId = default(System.Guid?), string resourceId = default(string), string resourceScope = default(string), string ruleName = default(string), string displayName = default(string), string message = default(string), NotificationLevel? level = default(NotificationLevel?), Channels? channels = default(Channels?), IList<string> tags = default(IList<string>), string actionName = default(string), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), System.DateTime? nextNotificationTime = default(System.DateTime?), System.DateTime? notificationExpirationTime = default(System.DateTime?), System.DateTime? notifiedTime = default(System.DateTime?), double? score = default(double?), bool? isDynamic = default(bool?), string extensionName = default(string), string bladeName = default(string), string forwardLink = default(string))
        {
            CreationTime = creationTime;
            RecommendationId = recommendationId;
            ResourceId = resourceId;
            ResourceScope = resourceScope;
            RuleName = ruleName;
            DisplayName = displayName;
            Message = message;
            Level = level;
            Channels = channels;
            Tags = tags;
            ActionName = actionName;
            StartTime = startTime;
            EndTime = endTime;
            NextNotificationTime = nextNotificationTime;
            NotificationExpirationTime = notificationExpirationTime;
            NotifiedTime = notifiedTime;
            Score = score;
            IsDynamic = isDynamic;
            ExtensionName = extensionName;
            BladeName = bladeName;
            ForwardLink = forwardLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets timestamp when this instance was created.
        /// </summary>
        [JsonProperty(PropertyName = "creationTime")]
        public System.DateTime? CreationTime { get; set; }

        /// <summary>
        /// Gets or sets a GUID value that each recommendation object is
        /// associated with.
        /// </summary>
        [JsonProperty(PropertyName = "recommendationId")]
        public System.Guid? RecommendationId { get; set; }

        /// <summary>
        /// Gets or sets full ARM resource ID string that this recommendation
        /// object is associated with.
        /// </summary>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }

        /// <summary>
        /// Gets or sets name of a resource type this recommendation applies,
        /// e.g. Subscription, ServerFarm, Site. Possible values include:
        /// 'ServerFarm', 'Subscription', 'WebSite'
        /// </summary>
        [JsonProperty(PropertyName = "resourceScope")]
        public string ResourceScope { get; set; }

        /// <summary>
        /// Gets or sets unique name of the rule.
        /// </summary>
        [JsonProperty(PropertyName = "ruleName")]
        public string RuleName { get; set; }

        /// <summary>
        /// Gets or sets UI friendly name of the rule (may not be unique).
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets recommendation text.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets level indicating how critical this recommendation can
        /// impact. Possible values include: 'Critical', 'Warning',
        /// 'Information', 'NonUrgentSuggestion'
        /// </summary>
        [JsonProperty(PropertyName = "level")]
        public NotificationLevel? Level { get; set; }

        /// <summary>
        /// Gets or sets list of channels that this recommendation can apply.
        /// Possible values include: 'Notification', 'Api', 'Email', 'Webhook',
        /// 'All'
        /// </summary>
        [JsonProperty(PropertyName = "channels")]
        public Channels? Channels { get; set; }

        /// <summary>
        /// Gets or sets the list of category tags that this recommendation
        /// belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IList<string> Tags { get; set; }

        /// <summary>
        /// Gets or sets name of action recommended by this object.
        /// </summary>
        [JsonProperty(PropertyName = "actionName")]
        public string ActionName { get; set; }

        /// <summary>
        /// Gets or sets the beginning time in UTC of a range that the
        /// recommendation refers to.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets the end time in UTC of a range that the recommendation
        /// refers to.
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets when to notify this recommendation next in UTC. Null
        /// means that this will never be notified anymore.
        /// </summary>
        [JsonProperty(PropertyName = "nextNotificationTime")]
        public System.DateTime? NextNotificationTime { get; set; }

        /// <summary>
        /// Gets or sets date and time in UTC when this notification expires.
        /// </summary>
        [JsonProperty(PropertyName = "notificationExpirationTime")]
        public System.DateTime? NotificationExpirationTime { get; set; }

        /// <summary>
        /// Gets or sets last timestamp in UTC this instance was actually
        /// notified. Null means that this recommendation hasn't been notified
        /// yet.
        /// </summary>
        [JsonProperty(PropertyName = "notifiedTime")]
        public System.DateTime? NotifiedTime { get; set; }

        /// <summary>
        /// Gets or sets a metric value measured by the rule.
        /// </summary>
        [JsonProperty(PropertyName = "score")]
        public double? Score { get; set; }

        /// <summary>
        /// Gets or sets true if this is associated with a dynamically added
        /// rule
        /// </summary>
        [JsonProperty(PropertyName = "isDynamic")]
        public bool? IsDynamic { get; set; }

        /// <summary>
        /// Gets or sets extension name of the portal if exists.
        /// </summary>
        [JsonProperty(PropertyName = "extensionName")]
        public string ExtensionName { get; set; }

        /// <summary>
        /// Gets or sets deep link to a blade on the portal.
        /// </summary>
        [JsonProperty(PropertyName = "bladeName")]
        public string BladeName { get; set; }

        /// <summary>
        /// Gets or sets forward link to an external document associated with
        /// the rule.
        /// </summary>
        [JsonProperty(PropertyName = "forwardLink")]
        public string ForwardLink { get; set; }

    }
}
