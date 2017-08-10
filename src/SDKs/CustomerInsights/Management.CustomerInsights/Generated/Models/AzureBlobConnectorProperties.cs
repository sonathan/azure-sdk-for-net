// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.CustomerInsights.Models
{
    using Azure;
    using Management;
    using CustomerInsights;
    using Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The Azure Blob connector properties.
    /// </summary>
    public partial class AzureBlobConnectorProperties
    {
        /// <summary>
        /// Initializes a new instance of the AzureBlobConnectorProperties
        /// class.
        /// </summary>
        public AzureBlobConnectorProperties() { }

        /// <summary>
        /// Initializes a new instance of the AzureBlobConnectorProperties
        /// class.
        /// </summary>
        /// <param name="connectionKeyVaultUrl">The connection KeyVault
        /// URL.</param>
        public AzureBlobConnectorProperties(string connectionKeyVaultUrl)
        {
            ConnectionKeyVaultUrl = connectionKeyVaultUrl;
        }

        /// <summary>
        /// Gets or sets the connection KeyVault URL.
        /// </summary>
        [JsonProperty(PropertyName = "connectionKeyVaultUrl")]
        public string ConnectionKeyVaultUrl { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ConnectionKeyVaultUrl == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ConnectionKeyVaultUrl");
            }
        }
    }
}
