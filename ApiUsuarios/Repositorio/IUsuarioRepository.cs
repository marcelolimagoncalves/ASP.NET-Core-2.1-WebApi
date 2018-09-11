using System.Collections.Generic;
using ApiUsuarios.Models;

namespace ApiUsuarios.Repositorio
{
    public interface IUsuarioRepository
    {
         void Add(Usuario user);
         IEnumerable<Usuario> GetAll();
         Usuario Find(long id);
         void Remove(long id);
         void Update(Usuario user);
    }
}