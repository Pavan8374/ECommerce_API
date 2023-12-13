using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NatShopB2C.Domain.IServices;
using NatShopB2C.Domain.Models;
using NatShopB2C_API.AccountModels;
using NatShopB2C_API.DTO;
using System.Net;

namespace NatShopB2C_API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("/api/Menu")]
    public class MenuController : ControllerBase
    {
        private readonly IMenuService _menuService;
        private readonly IMapper _mapper;
        protected Response response;
        public MenuController(IMenuService menuService, IMapper mapper)
        {
            _menuService = menuService;
            _mapper = mapper;
            this.response = new();
        }
        [HttpGet]
        [Route("GetMenus")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Response>> GetMenus()
        {
            try
            {
                List<MenuDTO> Mains = new List<MenuDTO>();
                var menuList = await _menuService.GetRootMenus();
                if (menuList != null)
                {
                    foreach (var item in menuList)
                    {
                        var MainMenu = _mapper.Map<MenuDTO>(item);
                        MainMenu.SubMenu = new List<MenuDTO>();

                        List<Menu> subMenuList1 = await _menuService.GetSubMenus(item.Id);
                        if (subMenuList1 == null)
                        {
                            return NotFound();
                        }
                        foreach (var item1 in subMenuList1)
                        {
                            var subMenuList2 = await _menuService.GetSubMenus(item1.Id);
                            if (subMenuList2 == null)
                            {
                                return NotFound();
                            }
                            var subMenu2 = new List<MenuDTO>();
                            foreach (var item2 in subMenuList2)
                            {
                                subMenu2.Add(_mapper.Map<MenuDTO>(item2));
                            }
                            MenuDTO subMenu1 = new MenuDTO();
                            subMenu1 = _mapper.Map<MenuDTO>(item1);
                            subMenu1.SubMenu = new List<MenuDTO>();
                            subMenu1.SubMenu.AddRange(subMenu2);    // Add sub menu list 2
                            MainMenu.SubMenu.Add(subMenu1);    //Add sub menu list 1
                        }
                        Mains.Add(MainMenu);                       
                    }
                    response.Result = Mains;
                    response.StatusCode = HttpStatusCode.OK;
                    return Ok(response);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Menu list not found" });
                }
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
