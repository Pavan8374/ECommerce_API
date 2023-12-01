using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NatShopB2C_API.Controllers
{
    [ApiController]
    [Route("/api/WishList"), Authorize]
    public class WishListController : ControllerBase
    {
       
    }
}
