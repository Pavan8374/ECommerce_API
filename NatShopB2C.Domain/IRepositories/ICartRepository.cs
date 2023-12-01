using NatShopB2C.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.IRepositories
{
    public interface ICartRepository
    {
        Task<Cart> AddItemToCart(Cart items);
        Task<Cart> UpdateCart(Cart items);
        Task<Cart> RemoveItemsFromCart(Cart items);
        Task<List<Cart>> GetItems();
        Task<Cart> GetCart(int id);
    }
}
