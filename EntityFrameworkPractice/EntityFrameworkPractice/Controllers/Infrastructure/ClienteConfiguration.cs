using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFrameworkPractice.Controllers.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameworkPractice.Controllers.Infrastructure
{
    public class ClienteConfiguration : PessoaConfiguration<Cliente>, IEntityTypeConfiguration<Cliente>
    {
        public new void Configure(EntityTypeBuilder<Cliente> builder)
        {
            base.Configure(builder);
            builder.Property("Prestigio");
        }
    }
}
