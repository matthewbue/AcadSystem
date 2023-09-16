using AcadSistemAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AcadSistemAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {
     
        [HttpPost(Name = "CreateAluno")] 
        public ActionResult CreateAluno (Aluno aluno)
        {
            string resultado = "sucesso";
            return Ok(resultado);
        }
    }
}
