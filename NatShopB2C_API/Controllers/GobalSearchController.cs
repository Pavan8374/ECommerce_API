using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NatShopB2C.Domain.DTO;
using NatShopB2C.Domain.IServices;
using NatShopB2C.Domain.Services;
using NatShopB2C_API.AccountModels;
using NatShopB2C_API.DTO;

namespace NatShopB2C_API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("/api/GobalSearch")]
    public class GobalSearchController : ControllerBase
    {
        private readonly IGlobalSearchService _globalSearchService;
        private readonly IMapper _mapper;
        protected Response response;
        public GobalSearchController(IGlobalSearchService globalSearchService, IMapper mapper)
        {
            _globalSearchService = globalSearchService;
            _mapper = mapper;
            this.response = new Response();
        }
        [HttpGet]
        [Route("GlobalSearch")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Response>> GlobalSearch(string SearchKeyword="")
        {
            try
            {
                if (SearchKeyword == null)
                {
                    return BadRequest();
                }
                var searchlist = await _globalSearchService.GlobalSearch(SearchKeyword);
                if (searchlist == null)
                {
                    return NotFound();
                }
                response.Result = searchlist;
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
