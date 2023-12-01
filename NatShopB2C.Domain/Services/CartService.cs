using NatShopB2C.Domain.IRepositories;
using NatShopB2C.Domain.IServices;
using NatShopB2C.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatShopB2C.Domain.Services
{
    public class CartService: ICartService
    {
        private readonly ICartRepository _cartRepository;
        public CartService(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public async Task<Cart> AddItemToCart(Cart items)
        {
            var cart = await _cartRepository.AddItemToCart(items);
            return cart;
        }
        public async Task<Cart> UpdateCart(Cart items)
        {
            var cart = await _cartRepository.UpdateCart(items);
            return cart;
        }
        public async Task<Cart> GetCart(int id)
        {
            var cart = await _cartRepository.GetCart(id);
            return cart;
        }

        public async Task<List<Cart>> GetItems()
        {
            var items = await _cartRepository.GetItems();
            return items;
        }

        public async Task<Cart> RemoveItemsFromCart(Cart cart)
        {
            var items = await _cartRepository.RemoveItemsFromCart(cart);
            return items;
        }        
    }
}
