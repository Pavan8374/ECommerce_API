using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NatShopB2C.Domain.IServices;
using NatShopB2C.Domain.Models;
using NatShopB2C.Domain.Services;
using NatShopB2C_API.AccountModels;
using NatShopB2C_API.DTO;

namespace NatShopB2C_API.Controllers.Account
{
    [Authorize]
    [ApiController]
    [Route("/api/AccountInformation")]
    public class AccountInformationController : Controller
    {
        public readonly IAccountService _accountService;
        private readonly IMapper _mapper;
        protected Response response;
        public AccountInformationController(IAccountService accountService, IMapper mapper)
        {
            _accountService= accountService;
            _mapper =  mapper;
            this.response = new();
        }

        [HttpPost]
        [Route("UpsertUserDetails")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Response>> AddUserDetails(UserDetailDTO DTO)
        {
            try
            {
                if (DTO == null)
                {
                    return NotFound();
                }
                var obj = _mapper.Map<UserDetail>(DTO);

                if (DTO.UserId != null)
                {
                    var user = await _accountService.GetUserDetailsById(obj.UserId);
                    if(user == null)
                    {
                        response.Result = await _accountService.AddUserDetails(obj);
                        response.StatusCode = System.Net.HttpStatusCode.Created; 
                        response.Message = "User details Added successfully";
                        return Ok(response);

                    }
                    else
                    {
                        response.Result = await _accountService.UpdateUserDetails(obj);
                        response.StatusCode = System.Net.HttpStatusCode.NoContent;
                        response.Message = "User details Updated successfully";
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
        [Route("DeleteUserDetails")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Response>> DeleteUserDetails(Guid? Id)
        {
            try
            {
                var userDetail = await _accountService.GetUserDetailsById(Id);
                if (userDetail == null)
                {
                    return NotFound();
                }
                await _accountService.DeleteUserDetails(userDetail);
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
        [Route("GetUserDetails")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Response>> GetUserDetails()
        {
            try
            {
                var products = await _accountService.GetUserDetails();
                if (products == null)
                {
                    return NotFound();
                }
                response.Result = _mapper.Map<List<UserDetailDTO>>(products);
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
        [Route("GetUserDetailsById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Response>> GetUserDetailsById(Guid? Id)
        {
            try
            {
                if (Id == null)
                {
                    return BadRequest();
                }
                var product = await _accountService.GetUserDetailsById(Id);
                if (product == null)
                {
                    return NotFound();
                }
                response.Result = _mapper.Map<List<UserDetailDTO>>(product);
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
    