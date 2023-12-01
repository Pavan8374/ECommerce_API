using NatShopB2C.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.IRepositories
{
    public interface IWishListRepository
    {
        Task<Cart> AddItemToWishList(Cart cart);
        Task<Cart> UpdateWishList(Cart cart);
        Task<Cart> RemoveItemsFromWishList(Cart cart);
        Task<List<Cart>> GetItems(Cart cart);
        Task<Cart> GetCart(int id);
    }
}
