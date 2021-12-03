using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace TCC.Application.Rest.Controllers
{
    [ApiController]
    public abstract class BaseController : ControllerBase
    {
        protected async Task<T> DeserializarAsync<T>(Stream serializedObjectStream)
        {
            var response = await JsonSerializer.DeserializeAsync<T>(serializedObjectStream, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return response;
        }

        protected T Deserializar<T>(string serializedObject)
        {
            return JsonSerializer.Deserialize<T>(serializedObject, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }
}
