using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using TCC.Application.GRPC.Models;

namespace TCC.Application.GRPC.Repository
{
    public interface IPaisRepository
    {
        Task<Pais> GetPaisAsync(string nome);
    }

    public class PaisRepository : IPaisRepository
    {
        public async Task<Pais> GetPaisAsync(string nome)
        {
            try
            {
                var pathData = Path.Combine(Directory.GetCurrentDirectory(), "Data", "data.json");

                using (var fs = new FileStream(pathData, FileMode.Open, FileAccess.Read))
                {
                    var paises = await JsonSerializer.DeserializeAsync<List<Pais>>(fs, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                    var pais = paises.FirstOrDefault(x => x.NomePais.ToUpper() == nome.ToUpper());

                    return pais;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
    }
}
