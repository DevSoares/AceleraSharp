using EntityFrameworkPractice.Controllers.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkPractice.Controllers.Infrastructure
{
    public class PessoaConfiguration<Tentity> : IEntityTypeConfiguration<Tentity> where Tentity : Pessoa
    {
        public void Configure(EntityTypeBuilder<Tentity> builder)
        {
            builder.HasKey("PessoaId");
            builder.Property("Nome");
            builder.Property("DataNascimento");
        }
    }
}
