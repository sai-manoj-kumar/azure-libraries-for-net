// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Devices.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Devices;
    using Microsoft.Azure.Management.Devices.Fluent;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for IotHubNameUnavailabilityReason.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IotHubNameUnavailabilityReason
    {
        [EnumMember(Value = "Invalid")]
        Invalid,
        [EnumMember(Value = "AlreadyExists")]
        AlreadyExists
    }
    internal static class IotHubNameUnavailabilityReasonEnumExtension
    {
        internal static string ToSerializedValue(this IotHubNameUnavailabilityReason? value)
        {
            return value == null ? null : ((IotHubNameUnavailabilityReason)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this IotHubNameUnavailabilityReason value)
        {
            switch( value )
            {
                case IotHubNameUnavailabilityReason.Invalid:
                    return "Invalid";
                case IotHubNameUnavailabilityReason.AlreadyExists:
                    return "AlreadyExists";
            }
            return null;
        }

        internal static IotHubNameUnavailabilityReason? ParseIotHubNameUnavailabilityReason(this string value)
        {
            switch( value )
            {
                case "Invalid":
                    return IotHubNameUnavailabilityReason.Invalid;
                case "AlreadyExists":
                    return IotHubNameUnavailabilityReason.AlreadyExists;
            }
            return null;
        }
    }
}
