using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NatShopB2C.Domain.IServices;
using NatShopB2C.Domain.Models;
using NatShopB2C.Domain.Services;
using NatShopB2C_API.AccountModels;
using NatShopB2C_API.DTO;

namespace NatShopB2C_API.Controllers
{
    [ApiController]
    [Route("/api/Cart"), Authorize]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;
        private readonly IMapper _mapper;
        protected Response response;
        public CartController(ICartService cartService, IMapper mapper)
        {
            _cartService = cartService;
            _mapper = mapper;
            this.response = new();
        }

        [HttpPost]
        [Route("ManageCart")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Response>> ManageCart(CartDTO DTO)
        {

            try
            {
                if (DTO == null)
                {
                    return NotFound();
                }
                var obj = _mapper.Map<Cart>(DTO);

                if (DTO.Id == 0)
                {
                    response.Result = await _cartService.AddItemToCart(obj);
                    response.StatusCode = System.Net.HttpStatusCode.Created;
                    return Ok(response);
                }
                else
                {
                    response.Result = await _cartService.UpdateCart(obj);
                    response.StatusCode = System.Net.HttpStatusCode.NoContent;
                    return Ok(response);
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return response;
        }
        [HttpDelete]
        [Route("RemoveItemsFromCart")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Response>> RemoveItemsFromCart(int id)
        {
            try
            {

                var cart = await _cartService.GetCart(id);
                if (cart == null)
                {
                    return NotFound();
                }
                await _cartService.RemoveItemsFromCart(cart);
                response.StatusCode = System.Net.HttpStatusCode.NoContent;
                response.IsSuccess = true;
                return Ok(response);
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return response;

        }
        [HttpGet]
        [Route("GetItems")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Response>> GetItems()
        {
            try
            {
                var cart = await _cartService.GetItems();
                if (cart == null)
                {
                    return NotFound();
                }
                response.Result = _mapper.Map<List<CartDTO>>(cart);
                response.StatusCode = System.Net.HttpStatusCode.OK;
                return Ok(response);
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return response;

        }
        [HttpGet]
        [Route("GetCart")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Response>> GetCart(int id)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest();
                }
                var cart = await _cartService.GetCart(id);
                if (cart == null)
                {
                    return NotFound();
                }
                response.Result = _mapper.Map<CartDTO>(cart);
                response.StatusCode = System.Net.HttpStatusCode.OK;
                return Ok(response);
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return response;

        }
    }
}
