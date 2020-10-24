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
        
    }
}