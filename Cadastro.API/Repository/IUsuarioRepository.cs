using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cadastro.API.Model;

namespace Cadastro.API.Repository
{
    public interface IUsuarioRepository
    {
        public Usuario Incluir(Usuario obj);
        public Usuario Alterar(Usuario obj);
        public bool Excluir(int id);
        public IEnumerable<Usuario> Listar();
        public Usuario Obter(int id);
    }
}