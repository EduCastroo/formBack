using Cadastro.API.Data;
using Cadastro.API.Model;
using System.Collections.Generic;
using System.Linq;

namespace Cadastro.API.Repository
{
    public class SocioRepository : ISocioRepository
    {
        private readonly DatabaseContext _context;
        public SocioRepository(DatabaseContext ctx)
        {
            _context = ctx;
        }
        public Socio Alterar(Socio obj)
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

        public Socio Incluir(Socio obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
            return obj;
        }

        public IEnumerable<Socio> Listar()
        {
            return _context.Socios.ToList();
        }

        public Socio Obter(long id)
        {
            return _context.Socios.Where(a => a.Id == id).FirstOrDefault();
        }
    }
}
