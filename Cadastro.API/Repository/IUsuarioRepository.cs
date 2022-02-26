using System.Collections.Generic;
using Cadastro.API.Model;

namespace Cadastro.API.Repository
{
    public interface IUsuarioRepository
    {
        public Usuario Incluir(Usuario obj);
        public Usuario Alterar(Usuario obj);
        public bool Excluir(long id);
        public IEnumerable<Usuario> Listar();
        public Usuario Obter(long id);
    }
}