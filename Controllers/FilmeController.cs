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
        public List<Models.TbFilme> Consultar()
        {
            Models.db_filmeContext ctx = new Models.db_filmeContext();

            List<Models.TbFilme> filmes = ctx.TbFilme.ToList();
            return filmes;
           
        }

        [HttpGet("consultar")]
        public List<Models.TbFilme> ConsultarPorGenero(string genero)
        {
            Models.db_filmeContext ctx = new Models.db_filmeContext();

            List<Models.TbFilme> filmeFiltrado = ctx.TbFilme.Where(flm => flm.DsGenero == genero)
                                                                    .ToList();

            return filmeFiltrado;
        }

        // - VERBO PUT -

        [HttpPut]
        public void Alterar(Models.TbFilme filme)
        {
            Models.db_filmeContext ctx = new Models.db_filmeContext();

            Models.TbFilme atual = ctx.TbFilme.First(flm => flm.IdFilme == filme.IdFilme);
            atual.NmFilme = filme.NmFilme;
            atual.DsGenero = filme.DsGenero;
            atual.NrDuracao = filme.NrDuracao;
            atual.VlAvaliacao = filme.VlAvaliacao;
            atual.BtDisponivel = filme.BtDisponivel;
            atual.DtLancamento = filme.DtLancamento;

            ctx.SaveChanges();
        }

        [HttpPut("disponibilidade")]
        public void AlterarDisponibilidade(Models.TbFilme filme)
        {
            Models.db_filmeContext ctx = new Models.db_filmeContext();

            Models.TbFilme atual = ctx.TbFilme.First(flm => flm.IdFilme == filme.IdFilme);
            atual.BtDisponivel = filme.BtDisponivel;

            ctx.SaveChanges();
        }

        // - VERBO DELETE -

        [HttpDelete]
        public void RemoverFilme(Models.TbFilme filme)
        {
            Models.db_filmeContext ctx = new Models.db_filmeContext();

            Models.TbFilme atual = ctx.TbFilme.First(x => x.IdFilme == filme.IdFilme);
            ctx.TbFilme.Remove(atual);
            ctx.SaveChanges();
        }
        
        [HttpDelete("genero")]
        public void RemoverPorGenero(Models.TbFilme filme)
        {
            Models.db_filmeContext ctx = new Models.db_filmeContext();

            List<Models.TbFilme> filmes = ctx.TbFilme.Where(x => x.DsGenero == filme.DsGenero)
                                                                .ToList();

            ctx.TbFilme.RemoveRange(filmes);
            ctx.SaveChanges();
        }
    }
}