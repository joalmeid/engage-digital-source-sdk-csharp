using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace RingCentral.EngageDigital.SourceSdk.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Formatting
    {
        [EnumMember(Value = "html")]
        Html,
        [EnumMember(Value = "text")]
        Text,
    }
}
