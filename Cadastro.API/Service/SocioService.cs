using Cadastro.API.Repository;

namespace Cadastro.API.Service
{
    public class SocioService
    {
        private readonly ISocioRepository _socioRepo;

        public SocioService(ISocioRepository socioRepo)
        {
            _socioRepo = socioRepo;
        }

     }
}
