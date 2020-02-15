using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkPractice.Controllers.Models
{
    public class ItemVenda
    {
        [Key]
        [Column("ItemVendaId")]
        public int ItemVendaId { get; set; }
        public Venda Venda { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
    }
}
