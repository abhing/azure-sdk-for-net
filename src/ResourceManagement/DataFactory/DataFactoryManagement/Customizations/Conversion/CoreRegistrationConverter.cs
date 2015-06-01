﻿//
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using Microsoft.Azure.Management.DataFactories.Registration.Models;

namespace Microsoft.Azure.Management.DataFactories.Conversion
{
#if ADF_INTERNAL
    internal abstract class CoreRegistrationConverter<TCore, TWrapper, TTypeProperties> :
        PolymorphicTypeConverter<TTypeProperties> where TTypeProperties : TypeProperties
    {
        /// <summary>
        /// Converts <paramref name="wrappedObject"/> from type TCore to TWrapper.
        /// </summary>
        /// <param name="wrappedObject">
        /// The object to convert to its generic/core type equivalent.
        /// </param>
        /// <returns>The generic representation of <paramref name="wrappedObject"/>.</returns>
        public abstract TCore ToCoreType(TWrapper wrappedObject);

        /// <summary>
        /// Converts <paramref name="coreObject"/> from type TWrapper to TCore.
        /// </summary>
        /// <param name="coreObject">
        /// The object to convert to its strong/wrapped type equivalent.
        /// </param>
        /// <returns>The wrapped representation of <paramref name="coreObject"/>.</returns>
        public abstract TWrapper ToWrapperType(TCore coreObject);

        /// <summary>
        /// Checks if <paramref name="wrappedObject"/> is valid.
        /// </summary>
        /// <param name="wrappedObject">The object to validate.</param>
        public abstract void ValidateWrappedObject(TWrapper wrappedObject);
    }
#endif
}