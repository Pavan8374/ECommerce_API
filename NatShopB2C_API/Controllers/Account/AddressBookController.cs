using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NatShopB2C.Domain.IServices;
using NatShopB2C.Domain.Models;
using NatShopB2C_API.AccountModels;
using NatShopB2C_API.DTO;

namespace NatShopB2C_API.Controllers.Account
{
    [Authorize]
    [ApiController]
    [Route("/api/AddressBook")]
    public class AddressBookController : ControllerBase
    {
        private readonly IAddressBookService _addressBookService;
        private readonly IMapper _mapper;
        protected Response response;
        public AddressBookController(IAddressBookService addressBookService, IMapper mapper)
        {
            _addressBookService = addressBookService;
            _mapper = mapper;
            this.response = new();
        }
        [HttpPost]
        [Route("UpsertAddress")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Response>> UpsertAddress(AddressesDTO DTO)
        {
            try
            {
                if (DTO == null || DTO == null)
                {
                    return NotFound();
                }
                else
                {
                    
                    var address = _mapper.Map<Address>(DTO);
                    var uaddress = _mapper.Map<UserAddress>(DTO);
                    
                    if (address.Id == 0)
                    {
                        response.Result = await _addressBookService.AddAddress(address);
                        response.StatusCode = System.Net.HttpStatusCode.Created;
                        var newAddress = await _addressBookService.GetAddress(address.Id);
                        uaddress.AddressId = newAddress.Id;
                        if (DTO.UserId != null)
                        {
                            await _addressBookService.AddUserAddress(uaddress);
                        }
                        return Ok(response);
                    }
                    else
                    {
                        
                        var obj = await _addressBookService.UpdateAddress(address);

                        //to update userAdrees table

                        //response.Result = obj;
                        //uaddress.AddressId = address.Id;
                        //uaddress.IsActive = address.IsActive;
                        //uaddress.IsDelete = address.IsDelete;
                        //uaddress.ModifiedDate = System.DateTime.Now;
                        //await _addressBookService.UpdateUserAddress(uaddress);

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
        [Route("DeleteAddress")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Response>> DeleteAddress(int id)
        {
            try
            {
                var address = await _addressBookService.GetAddress(id);
                var userAddress = await _addressBookService.GetUserAddress(address.Id);
                if (address == null)
                {
                    return NotFound();
                }
                await _addressBookService.DeleteUserAddress(userAddress);
                await _addressBookService.DeleteAddress(address);
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
        [Route("GetAddresses")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Response>> GetAddresses()
        {
            try
            {
                var addresses = await _addressBookService.GetAddresses();
                if(addresses == null)
                {
                    return NotFound();
                }
                response.Result = _mapper.Map<List<AddressesDTO>>(addresses);
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
        [Route("GetAddress")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Response>> GetAddress(int id)
        {
            try
            {
                var address = await _addressBookService.GetAddress(id);
                if (address == null)
                {
                    return NotFound();
                }
                var obj= _mapper.Map<AddressDTO>(address);
                response.Result = obj;
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
        [Route("GetAddressTypes")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Response>> GetAddressTypes()
        {
            try
            {
                response.Result = await _addressBookService.GetAddressTypes();
                if (response.Result == null)
                {
                    return NotFound();
                }
                //response.Result = _mapper.Map<AddressDTO>(addresses);
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
