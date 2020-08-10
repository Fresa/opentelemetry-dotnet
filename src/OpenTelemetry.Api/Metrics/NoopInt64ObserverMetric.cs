﻿// <copyright file="NoopInt64ObserverMetric.cs" company="OpenTelemetry Authors">
// Copyright The OpenTelemetry Authors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>

using System.Collections.Generic;

namespace OpenTelemetry.Metrics
{
    /// <summary>
    /// A no-op observer instrument.
    /// </summary>
    public sealed class NoopInt64ObserverMetric : Int64ObserverMetric
    {
        /// <summary>
        /// No op observer instance.
        /// </summary>
        public static readonly Int64ObserverMetric Instance = new NoopInt64ObserverMetric();

        /// <inheritdoc/>
        public override void Observe(long value, LabelSet labelset)
        {
        }

        /// <inheritdoc/>
        public override void Observe(long value, IEnumerable<KeyValuePair<string, string>> labels)
        {
        }
    }
}