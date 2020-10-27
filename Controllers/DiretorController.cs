using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;

namespace apiFilme.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DiretorController : ControllerAttribute
    {
        [HttpPost]
        public Models.TbDiretor Salvar(Models.TbDiretor diretorFilme)
        {
            Models.db_filmeContext ctx = new Models.db_filmeContext();
            ctx.TbDiretor.Add(diretorFilme);
            ctx.SaveChanges();

            return diretorFilme; 
        }

        [HttpGet]
        public List<Models.TbDiretor> Listar()
        {
            Models.db_filmeContext ctx = new Models.db_filmeContext();

            List<Models.TbDiretor> diretores =  
                ctx.TbDiretor.Include(fml => fml.IdFilmeNavigation)
                            .ToList();
            return diretores;
        }
        
    }
}