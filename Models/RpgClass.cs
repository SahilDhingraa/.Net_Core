using System.Text.Json.Serialization;

namespace udemy1.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Banda = 1,
        Budi = 2,
        bandar = 3
    }
}