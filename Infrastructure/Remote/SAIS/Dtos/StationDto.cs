using System.Text.Json.Serialization;

namespace Infrastructure.Remote.SAIS.Dtos;

// SAIS tarafının döndürdüğü istasyon modeli (field adlarını dokümanına göre sabitle)
internal sealed record Up_Station(
    [property: JsonPropertyName("station_id")] string StationId,
    [property: JsonPropertyName("station_name")] string StationName,
    [property: JsonPropertyName("city")] string? City,
    [property: JsonPropertyName("is_active")] bool? IsActive
);

// SAIS'e gönderilecek güncelleme gövdesi (dokümandaki isteğe göre alanları düzenle)
internal sealed record Up_UpdateStationInformationRequest(
    [property: JsonPropertyName("station_id")] string StationId,
    [property: JsonPropertyName("station_name")] string? StationName,
    [property: JsonPropertyName("city")] string? City,
    [property: JsonPropertyName("is_active")] bool? IsActive
);
