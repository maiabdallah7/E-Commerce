using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Context;
using E_commerce;
namespace Infrastructure
{
    public class CartItemRepository: GenericRepository<CartItem>
    {
        private readonly AppDbContext _context;

        public CartItemRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
