using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Mvc;

namespace apiFilme.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        [HttpPost]
        public Models.TbFilme Salvar(Models.TbFilme filme)
        {
            Models.db_filmeContext ctx = new Models.db_filmeContext();
            
            ctx.TbFilme.Add(filme); 
            ctx.SaveChanges();

            return filme;
        }
        
        [HttpGet]
        public List<Models.TbFilme> Listar()
        {
            Models.db_filmeContext ctx = new Models.db_filmeContext();
            
            List<Models.TbFilme> filmes = ctx.TbFilme.ToList();
            return filmes;
        }

        [HttpGet("consultar")]
        public List<Models.TbFilme> ConsultarFilmes(string genero)
        {
            Models.db_filmeContext ctx = new Models.db_filmeContext();

            List<Models.TbFilme> filmesFiltro = ctx.TbFilme.Where( y => y.DsGenero == genero)
                                                            .ToList();
            return filmesFiltro;
        }
    }
}