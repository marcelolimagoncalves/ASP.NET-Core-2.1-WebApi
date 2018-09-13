using System.Collections.Generic;
using ApiUsuarios.Models;
using ApiUsuarios.Repositorio;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiUsuarios.Controllers
{
    [Route("api/[Controller]")]
    [Authorize()]
    public class UsuariosController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepositorio;
        public UsuariosController(IUsuarioRepository usuarioRepo)
        {
            _usuarioRepositorio = usuarioRepo;
        }

        [HttpGet]
        public IEnumerable<Usuario> GetAll()
        {
            return _usuarioRepositorio.GetAll();
        }

        [HttpGet("{id}", Name="GetUsuario")]
        public IActionResult GetById(long id)
        {
            var usuario = _usuarioRepositorio.Find(id);
            if(usuario == null)
                return NotFound();
            
            return new ObjectResult(usuario);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Usuario usuario)
        {
            if(usuario == null)
                return BadRequest();
            
            _usuarioRepositorio.Add(usuario);

            return CreatedAtRoute("GetUsuario",new {id=usuario.UsuarioId}, usuario);
        }

        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] Usuario usuario)
        {
            if(usuario == null || usuario.UsuarioId != id)
                return BadRequest();
            
            var _usuario = _usuarioRepositorio.Find(id);       

             if(_usuario == null)
                return NotFound();
            
            _usuario.Email = usuario.Email;
            _usuario.Nome = usuario.Nome;

            _usuarioRepositorio.Update(_usuario);
            return new NoContentResult();

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var usuario = _usuarioRepositorio.Find(id);
            
            if(usuario == null)
                return NotFound();

            _usuarioRepositorio.Remove(id);
            return new NoContentResult();
        }
    }
}