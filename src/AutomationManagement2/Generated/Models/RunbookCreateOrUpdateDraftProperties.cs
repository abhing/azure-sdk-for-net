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
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// The parameters supplied to the create or update dratft runbook
    /// properties.
    /// </summary>
    public partial class RunbookCreateOrUpdateDraftProperties
    {
        private string _description;
        
        /// <summary>
        /// Optional. Gets or sets the description of the runbook.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private RunbookDraft _draft;
        
        /// <summary>
        /// Required. Gets or sets the draft runbook properties.
        /// </summary>
        public RunbookDraft Draft
        {
            get { return this._draft; }
            set { this._draft = value; }
        }
        
        private bool _logProgress;
        
        /// <summary>
        /// Optional. Gets or sets progress log option.
        /// </summary>
        public bool LogProgress
        {
            get { return this._logProgress; }
            set { this._logProgress = value; }
        }
        
        private bool _logVerbose;
        
        /// <summary>
        /// Optional. Gets or sets verbose log option.
        /// </summary>
        public bool LogVerbose
        {
            get { return this._logVerbose; }
            set { this._logVerbose = value; }
        }
        
        private string _runbookType;
        
        /// <summary>
        /// Required. Gets or sets the type of the runbook.
        /// </summary>
        public string RunbookType
        {
            get { return this._runbookType; }
            set { this._runbookType = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// RunbookCreateOrUpdateDraftProperties class.
        /// </summary>
        public RunbookCreateOrUpdateDraftProperties()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// RunbookCreateOrUpdateDraftProperties class with required arguments.
        /// </summary>
        public RunbookCreateOrUpdateDraftProperties(string runbookType, RunbookDraft draft)
            : this()
        {
            if (runbookType == null)
            {
                throw new ArgumentNullException("runbookType");
            }
            if (draft == null)
            {
                throw new ArgumentNullException("draft");
            }
            this.RunbookType = runbookType;
            this.Draft = draft;
        }
    }
}