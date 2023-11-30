using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NatShopB2C_API.AccountModels;
using NatShopB2C.Domain.IServices;
using NatShopB2C.Domain.Models;
using NatShopB2C_API.DTO;

namespace NatShopB2C_API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("/api/Product")]
    public class ProductController : ControllerBase
    {       
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        protected Response response;
        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService= productService;
            _mapper = mapper;
            this.response = new();
        }

        [HttpPost]
        [Route("UpsertProduct")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Response>> UpsertProduct(ProductDTO DTO)
        {
            try
            {
                if(DTO == null)
                {
                    return NotFound();
                }
                var obj = _mapper.Map<Product>(DTO);

                if (DTO.ProductID == null || DTO.ProductID == "")
                {
                    response.Result = await _productService.AddProduct(obj);
                    response.StatusCode = System.Net.HttpStatusCode.Created;
                    return Ok(response);
                }
                else
                {
                    response.Result = await _productService.UpdateProduct(obj);
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
        [Route("DeleteProduct")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Response>> DeleteProduct(Guid id)
        {
            try
            {

                var product = await _productService.GetProduct(id);
                if (product == null)
                {
                    return NotFound();
                }
                await _productService.DeleteProduct(product);
                response.StatusCode = System.Net.HttpStatusCode.NoContent;
                response.IsSuccess = true;
                return Ok(response);
            }
            catch(Exception ex)
            {
                response.IsSuccess = false;
                response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return response;

        }
        [HttpGet]
        [Route("GetProducts")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Response>> GetProducts()
        {
            try
            {
                var products = await _productService.GetProducts();
                if (products == null)
                {
                    return NotFound();
                }
                response.Result = _mapper.Map<List<ProductDTO>>(products);
                response.StatusCode = System.Net.HttpStatusCode.OK;              
                return Ok(response);
            }
            catch(Exception ex)
            {
                response.IsSuccess = false;
                response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return response;

        }
        [HttpGet]
        [Route("GetProduct")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Response>> GetProduct(Guid? id)
        {
            try
            {
                if (id == null)
                {
                    return BadRequest();
                }
                var product = await _productService.GetProduct(id);
                if (product == null)
                {
                    return NotFound();
                }
                response.Result = _mapper.Map<List<ProductDTO>>(product);
                response.StatusCode = System.Net.HttpStatusCode.OK;
                return Ok(response);
            }
            catch(Exception ex)
            {
                response.IsSuccess = false;
                response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return response;

        }
    }
}
