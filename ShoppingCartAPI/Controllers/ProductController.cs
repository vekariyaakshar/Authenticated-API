using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Authorize] // Requires authorization for all actions in the controller
[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly ProductController _productService;

    public ProductController(ProductController productService)
    {
        _productService = productService;
    }

    // Add your actions here
}
