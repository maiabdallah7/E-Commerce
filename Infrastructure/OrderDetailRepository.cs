using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_commerce;
using Context;
namespace Infrastructure
{
    public class OrderDetailRepository: GenericRepository<OrderDetail>
    {
        private readonly AppDbContext _context;

        public OrderDetailRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
