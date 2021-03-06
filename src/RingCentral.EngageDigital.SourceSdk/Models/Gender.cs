﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace RingCentral.EngageDigital.SourceSdk.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Gender
    {
        [EnumMember(Value = "man")]
        Man,
        [EnumMember(Value = "woman")]
        Woman,
    }
}
