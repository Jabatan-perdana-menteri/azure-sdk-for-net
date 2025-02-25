// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class DataVersionBaseResourceArmPaginatedResult
    {
        internal static DataVersionBaseResourceArmPaginatedResult DeserializeDataVersionBaseResourceArmPaginatedResult(JsonElement element)
        {
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<DataVersionBaseData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DataVersionBaseData> array = new List<DataVersionBaseData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataVersionBaseData.DeserializeDataVersionBaseData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new DataVersionBaseResourceArmPaginatedResult(nextLink.Value, Optional.ToList(value));
        }
    }
}
