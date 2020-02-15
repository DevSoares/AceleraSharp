using EntityFrameworkPractice.Controllers.Infrastructure;
using EntityFrameworkPractice.Controllers.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkPractice.Services
{
    public class VendedorService : IService<Vendedor>
    {
        private readonly ApplicationContext context;
        public VendedorService(ApplicationContext context)
        {
            this.context = context;
        }

        public void Add(Vendedor entity)
        {
            if (context.Entry(entity).State == EntityState.Detached)
                context.Entry(entity).State = EntityState.Added;

            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Vendedor entity)
        {
            context.Remove(entity);
            context.SaveChanges();
        }

        public Vendedor Get(int id)
        {
            return context.Vendedores.FirstOrDefault(v => v.PessoaId == id);
        }

        public void Update(Vendedor entity)
        {
            context.Update(entity);
            context.SaveChanges();
        }
    }
}
