using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkPractice.Controllers.Models
{
    public class Venda
    {
        [Key]
        public int VendaId { get; set; }
        public DateTime Data { get; set; }
        public List<ItemVenda> ItemVendaList { get; set; }
        public Cliente Cliente { get; set; }
        public Vendedor Vendedor { get; set; }
    }
}
