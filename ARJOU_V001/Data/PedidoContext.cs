using ARJOU_V001.Models;
using Microsoft.EntityFrameworkCore;

namespace ARJOU_V001.Data
{
    public class PedidoContext : DbContext
    {
        public PedidoContext(DbContextOptions<PedidoContext> options) : base(options) { }
        public DbSet<Pedido> PedidoSet { get; set; }

    }
}
