using System.Text.Json.Serialization;

namespace TCC.Application.GRPC.Models
{
    public class Pais
    {
        public string Gentilico { get; set; }

        [JsonPropertyName("nome_pais")]
        public string NomePais { get; set; }

        [JsonPropertyName("nome_pais_int")]
        public string NomePaisInternacional { get; set; }

        public string Sigla { get; set; }
    }
}
