// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.WindowsAzure.Management.WebSites.Models
{
    /// <summary>
    /// Describes a Biztalk Hybrid Connection for a web site.
    /// </summary>
    public partial class HybridConnection
    {
        private string _biztalkUri;
        
        /// <summary>
        /// Optional. The resource uri of the biztalk service. This field is
        /// optional; Without it the Azure Portal will not be able to display
        /// the biztalk service for this connection properly.
        /// </summary>
        public string BiztalkUri
        {
            get { return this._biztalkUri; }
            set { this._biztalkUri = value; }
        }
        
        private string _entityConnectionString;
        
        /// <summary>
        /// Optional. The biztalk application connection string for this
        /// connection
        /// </summary>
        public string EntityConnectionString
        {
            get { return this._entityConnectionString; }
            set { this._entityConnectionString = value; }
        }
        
        private string _entityName;
        
        /// <summary>
        /// Optional. The unique name for this connection
        /// </summary>
        public string EntityName
        {
            get { return this._entityName; }
            set { this._entityName = value; }
        }
        
        private string _hostname;
        
        /// <summary>
        /// Optional. The hostname of the target on-premise resource
        /// </summary>
        public string Hostname
        {
            get { return this._hostname; }
            set { this._hostname = value; }
        }
        
        private int _port;
        
        /// <summary>
        /// Optional. The port of the target on-premise resource
        /// </summary>
        public int Port
        {
            get { return this._port; }
            set { this._port = value; }
        }
        
        private string _resourceConnectionString;
        
        /// <summary>
        /// Optional. Reserved for future use. The connection string for the
        /// resource. This field is optional.
        /// </summary>
        public string ResourceConnectionString
        {
            get { return this._resourceConnectionString; }
            set { this._resourceConnectionString = value; }
        }
        
        private string _resourceType;
        
        /// <summary>
        /// Optional. Reserved for future use. The type of resource to be
        /// connected. This field is optional.
        /// </summary>
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the HybridConnection class.
        /// </summary>
        public HybridConnection()
        {
        }
    }
}
