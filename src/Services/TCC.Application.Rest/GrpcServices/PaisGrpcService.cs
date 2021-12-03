using System.Threading.Tasks;
using TCC.Application.GRPC.Protos;

namespace TCC.Application.Rest.GrpcServices
{
    public class PaisGrpcService
    {
        private readonly PaisProtoService.PaisProtoServiceClient _client;

        public PaisGrpcService(PaisProtoService.PaisProtoServiceClient client)
        {
            _client = client;
        }

        public async Task<PaisModel> GetPaisNomeAsync(string nome)
        {
            var getPaisRequest = new GetPaisNomeRequest { Nome = nome };
            return await _client.GetPaisAsync(getPaisRequest);
        }
    }
}
