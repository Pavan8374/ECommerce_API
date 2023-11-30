using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NatShopB2C.Domain.IServices;
using NatShopB2C.Domain.Models;
using NatShopB2C_API.AccountModels;
using NatShopB2C_API.DTO;

namespace NatShopB2C_API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("/api/Brand")]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService _brandService;
        private readonly IMapper _mapper;
        protected Response response;
        public BrandController(IBrandService brandService, IMapper mapper)
        {
            _brandService = brandService;
            _mapper = mapper;
            this.response = new ();
        }

        [HttpPost]
        [Route("UpSertBrand")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Response>> UpSertBrand(BrandDTO DTO)
        {
            try
            {
                if (DTO == null || DTO == null)
                {
                    return NotFound();
                }
                else
                {
                    var brand = _mapper.Map<Brand>(DTO);
                    if (brand.Id == 0)
                    {
                        response.Result = await _brandService.AddBrand(brand);
                        response.StatusCode = System.Net.HttpStatusCode.Created;

                        return Ok(response);
                    }
                    else
                    {
                        response.Result = await _brandService.UpdateBrand(brand);
                        response.StatusCode = System.Net.HttpStatusCode.NoContent;
                        return Ok(response);
                    }
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
        [Route("DeleteBrand")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Response>> DeleteBrand(int id)
        {
            try
            {
                var brand = await _brandService.GetBrand(id);
                if (brand == null)
                {
                    return NotFound();
                }
                await _brandService.DeleteBrand(brand);
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
        [Route("GetBrands")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Response>> GetBrands()
        {
            try
            {
                var brands = await _brandService.GetBrands();
                if (brands == null)
                {
                    return NotFound();
                }
                response.Result = _mapper.Map<List<BrandDTO>>(brands);
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
        [Route("GetBrand")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Response>> GetBrand(int id)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest();
                }
                var brand = await _brandService.GetBrand(id);
                if (brand == null)
                {
                    return NotFound();
                }
                response.Result = _mapper.Map<BrandDTO>(brand);
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
