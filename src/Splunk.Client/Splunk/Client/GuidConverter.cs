﻿/*
 * Copyright 2014 Splunk, Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License"): you may
 * not use this file except in compliance with the License. You may obtain
 * a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations
 * under the License.
 */

//// TODO:
//// [O] Contracts
//// [O] Documentation

namespace Splunk.Client
{
    using System;
    using System.IO;

    /// <summary>
    /// Provides a converter to convert strings to <see cref="Guid"/> values.
    /// </summary>
    sealed class GuidConverter : ValueConverter<Guid>
    {
        /// <summary>
        /// The default <see cref="GuidConverter"/> instance.
        /// </summary>
        public static readonly GuidConverter Instance = new GuidConverter();

        /// <summary>
        /// Converts the string representation of the <see cref="input"/> 
        /// object to a <see cref="Guid"/>.
        /// </summary>
        /// <param name="input">
        /// The object to convert.
        /// </param>
        /// <returns>
        /// Result of the conversion.
        /// </returns>
        /// <exception cref="InvalidDataException">
        /// The <see cref="input"/> does not represent a <see cref="Guid"/>
        /// value.
        /// </exception>
        public override Guid Convert(object input)
        {
            var x = input as Guid?;

            if (x != null)
            {
                return x.Value;
            }

            Guid value;

            if (Guid.TryParse(input.ToString(), result: out value))
            {
                return value;
            }

            throw new InvalidDataException(string.Format("Expected {0}: {1}", TypeName, input)); // TODO: improved diagnostices
        }
    }
}
