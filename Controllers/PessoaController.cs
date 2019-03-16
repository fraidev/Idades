
using System.Collections.Generic;
using System.Linq;
using Idades.Models;
using Microsoft.AspNetCore.Mvc;

namespace Idades.Controllers
{

    [Route("api/[controller]")]
    public class PessoaController : Controller
    {
        [HttpGet("[action]/{nome}")]
        public int IsRegistered(string nome)
        {
            var pessoas = new List<Pessoa>();
            pessoas.Add(new Pessoa("felipe", 21)); 
            pessoas.Add(new Pessoa("carol", 20));
            pessoas.Add(new Pessoa("maria", 30));
            pessoas.Add(new Pessoa("clara", 10));
            pessoas.Add(new Pessoa("miguel", 17));
            pessoas.Add(new Pessoa("joao", 10));
            var pessoa = pessoas.FirstOrDefault(x => x.Nome == nome.ToLower());
            if (pessoa != null)
            {
                return pessoa.Idade;
            }
            return -1;
        }
    }
}