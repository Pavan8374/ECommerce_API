using NatShopB2C.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.IServices
{
    public interface ICartService
    {
        Task<Cart> AddItemToCart(Cart cart);
        Task<Cart> UpdateCart(Cart cart);
        Task<Cart> RemoveItemsFromCart(Cart cart);
        Task<List<Cart>> GetItems();
        Task<Cart> GetCart(int id);
    }
}
