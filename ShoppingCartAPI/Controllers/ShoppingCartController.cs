using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Authorize] // This attribute requires authorization for all actions in the controller
[ApiController]
[Route("api/[controller]")]
public class ShoppingCartController : ControllerBase
{
    // Actions will be added in the following steps
}
