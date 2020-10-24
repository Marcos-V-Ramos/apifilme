using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Mvc;

namespace apiFilme.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AtorController : ControllerBase
    {
        public Models.TbAtor Ator(Models.TbAtor ator)
        {
            Models.db_filmeContext db = new Models.db_filmeContext();

            db.Add(ator);
            db.SaveChanges();

            return ator;
        }
        
    }
}