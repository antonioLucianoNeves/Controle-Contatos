using ControleContatos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleContatos.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) 
        { 
        }
        //Comando 2° para criar o migration e Tabelas dentro do BD os contatos Update-Database -Context BancoContext
        public DbSet<ContatoModel> Contatos { get; set; }
        
    }
}
