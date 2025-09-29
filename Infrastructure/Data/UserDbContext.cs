using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data
{
    public class UsuarioDbContext : DbContext
    {

        public UsuarioDbContext(DbContextOptions<UsuarioDbContext> options) : base(options){ }

        public DbSet<Usuario> Usuarios => Set<Usuario>();

    }
}
