using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFrameworkPractice.Controllers.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameworkPractice.Controllers.Infrastructure
{
    public class VendedorConfiguration : PessoaConfiguration<Vendedor>, IEntityTypeConfiguration<Vendedor>
    {
        public new void Configure(EntityTypeBuilder<Vendedor> builder)
        {
            base.Configure(builder);
            builder.Property("PorcentagemComissao");
            builder.Property("Setor");
            builder.Property("Salario");
        }
    }
}
