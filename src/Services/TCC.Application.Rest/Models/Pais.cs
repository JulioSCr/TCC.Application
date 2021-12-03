using System.Text.Json.Serialization;

namespace TCC.Application.Rest.Models
{
    public class Pais
    {
        [JsonPropertyName("gentilico")]
        public string Gentilico { get; set; }

        [JsonPropertyName("nome_pais")]
        public string NomePais { get; set; }

        [JsonPropertyName("nome_pais_int")]
        public string NomePaisInternacional { get; set; }
        
        [JsonPropertyName("sigla")]
        public string Sigla { get; set; }
    }
}
