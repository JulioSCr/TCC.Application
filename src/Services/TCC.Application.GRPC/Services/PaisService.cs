using AutoMapper;
using Grpc.Core;
using System.Threading.Tasks;
using TCC.Application.GRPC.Protos;
using TCC.Application.GRPC.Repository;

namespace TCC.Application.GRPC.Services
{
    public class PaisService : PaisProtoService.PaisProtoServiceBase
    {
        private readonly IMapper _mapper;
        private readonly IPaisRepository _paisRepository;

        public PaisService(IMapper mapper, IPaisRepository paisRepository)
        {
            _mapper = mapper;
            _paisRepository = paisRepository;
        }

        public override async Task<PaisModel> GetPais(GetPaisNomeRequest request, ServerCallContext context)
        {
            var pais = await _paisRepository.GetPaisAsync(request.Nome);

            if (pais == null) throw new RpcException(new Status(StatusCode.NotFound, "Paises não encontrados."));

            return _mapper.Map<PaisModel>(pais);
        }
    }
}
