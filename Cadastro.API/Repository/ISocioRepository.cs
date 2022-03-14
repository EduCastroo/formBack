using System.Collections.Generic;
using Cadastro.API.Model;

namespace Cadastro.API.Repository
{
    public interface ISocioRepository
    {
        public Socio Incluir(Socio obj);
        public Socio Alterar(Socio obj);
        public bool Excluir(long id);
        public IEnumerable<Socio> Listar();
        public Socio Obter(long id);
    }
}