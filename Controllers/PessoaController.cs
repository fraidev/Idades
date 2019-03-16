
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
            pessoas.Add(new Pessoa("maria", 32));
            pessoas.Add(new Pessoa("clara", 13));
            pessoas.Add(new Pessoa("miguel", 17));
            pessoas.Add(new Pessoa("joao", 15));
            pessoas.Add(new Pessoa("carlos", 41)); 
            pessoas.Add(new Pessoa("samanta", 63));
            pessoas.Add(new Pessoa("jenifer", 36));
            pessoas.Add(new Pessoa("eric", 14));
            pessoas.Add(new Pessoa("evans", 17));
            pessoas.Add(new Pessoa("andre", 32));
            pessoas.Add(new Pessoa("eduardo", 70));
            pessoas.Add(new Pessoa("rafael", 31));
            var pessoa = pessoas.FirstOrDefault(x => x.Nome == nome.ToLower());
            if (pessoa != null)
            {
                return pessoa.Idade;
            }
            return -1;
        }
    }
}