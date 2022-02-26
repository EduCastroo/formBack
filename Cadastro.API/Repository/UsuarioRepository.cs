using Cadastro.API.Data;
using Cadastro.API.Model;
using System.Collections.Generic;
using System.Linq;

namespace Cadastro.API.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly DatabaseContext _context;
        public UsuarioRepository(DatabaseContext ctx)
        {
            _context = ctx;
        }
        public Usuario Alterar(Usuario obj)
        {
            throw new System.NotImplementedException();
        }

        public bool Excluir(long id)
        {
            var obj = this.Obter(id);
            if(obj == null)
                return false;

            _context.Remove(obj);
            _context.SaveChanges();
            return true;
        }

        public Usuario Incluir(Usuario obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
            return obj;
        }

        public IEnumerable<Usuario> Listar()
        {
            return _context.Usuarios.ToList();
        }

        public Usuario Obter(long id)
        {
            return _context.Usuarios.Where(a => a.Id == id).FirstOrDefault();
        }
    }
}
