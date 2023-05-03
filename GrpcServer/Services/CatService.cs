using Grpc.Core;
using GrpcContract;

namespace GrpcServer.Services
{
    public class CatService : Cat.CatBase
    {
        private readonly ILogger<CatService> _logger;
        public CatService(ILogger<CatService> logger)
        {
            _logger = logger;
        }

        public override Task<PetReply> SayMiau(PetRequest request, ServerCallContext context)
        {
            return Task.FromResult(new PetReply
            {
                PetSaid = request.PetName + " said: Miau"
            });
        }
    }
}