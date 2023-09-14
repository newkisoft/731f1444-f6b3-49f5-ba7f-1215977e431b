using Microsoft.AspNetCore.Mvc;

namespace _731f1444_f6b3_49f5_ba7f_1215977e431b.Controllers;

[ApiController]
[Route("[controller]")]
public class SubSeqController : ControllerBase
{    
    private readonly ILogger<SubSeqController> _logger;

    public SubSeqController(ILogger<SubSeqController> logger)
    {
        _logger = logger;
    }

    [HttpGet()]
    public IEnumerable<string> Get()
    {
        var longest = new List<string>();
        return longest;
        
    }
}
