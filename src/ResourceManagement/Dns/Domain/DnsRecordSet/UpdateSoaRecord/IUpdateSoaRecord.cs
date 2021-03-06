// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Dns.Fluent.DnsRecordSet.UpdateSoaRecord
{
    using Microsoft.Azure.Management.Dns.Fluent.DnsRecordSet.Update;

    /// <summary>
    /// The entirety of a SOA record update as a part of parent DNS zone update.
    /// </summary>
    public interface IUpdateSoaRecord :
        Microsoft.Azure.Management.Dns.Fluent.DnsRecordSet.Update.IWithSoaRecordAttributes,
        Microsoft.Azure.Management.Dns.Fluent.DnsRecordSet.Update.IUpdate
    {
    }
}