using Microsoft.EntityFrameworkCore;
using NatShopB2C.Domain.IRepositories;
using NatShopB2C.Domain.Models;
using NatShopB2C.EF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.EF.Repositories
{
    public class CartRepository : ICartRepository
    {
        private readonly ApplicationDbContext _db;
        public CartRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Cart> AddItemToCart(Cart items)
        {
            await _db.Carts.AddAsync(items);
            await _db.SaveChangesAsync();
            return items;
        }
        public async Task<Cart> UpdateCart(Cart items)
        {
            _db.Carts.Update(items);
            await _db.SaveChangesAsync();
            return items;
        }
        public async Task<Cart> GetCart(int id)
        {
            var cart = await _db.Carts.AsNoTracking().Where(x => x.Id == id).FirstOrDefaultAsync();
            return cart;
        }

        public async Task<List<Cart>> GetItems()
        {
            var items = await _db.Carts.AsNoTracking().ToListAsync();
            return items;
        }

        public async Task<Cart> RemoveItemsFromCart(Cart items)
        {
            _db.Carts.Remove(items);
            await _db.SaveChangesAsync();
            return items;
        }

        
    }
}
