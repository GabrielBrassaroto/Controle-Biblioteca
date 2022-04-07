using ControleBiblioteca.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleBiblioteca.Data
{
    public class LibaryContext : DbContext
    {
        //Construtor passa a classe de contexto para clase dbcontext do entity
        public LibaryContext(DbContextOptions<LibaryContext> options) :base(options)
        {
        }

        //tabela que vai ser criada no banco de dados
        public DbSet<BookModel> Books { get; set; }
    }
}
