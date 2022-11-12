using Gestao.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;

namespace Gestao.Web.Repositorio
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
          : base(options)
        { }
        public DbSet<Lancamento> Lancamentos { get; set; }
        
    }
}
