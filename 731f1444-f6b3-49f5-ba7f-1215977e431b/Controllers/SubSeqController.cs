using _731f1444_f6b3_49f5_ba7f_1215977e431b.Services;
using Microsoft.AspNetCore.Mvc;

namespace _731f1444_f6b3_49f5_ba7f_1215977e431b.Controllers;

[ApiController]
[Route("[controller]")]
public class SubSeqController : ControllerBase
{    
    private readonly ILogger<SubSeqController> _logger;
    private readonly ILongestSequenceService _longestService;

    public SubSeqController(ILogger<SubSeqController> logger,ILongestSequenceService longestSequenceService)
    {
        _logger = logger;
        _longestService = longestSequenceService;
    }

    [HttpGet()]
    public IEnumerable<int> Get(string numbers)
    {
        return _longestService.GetLongestList(numbers);        
    }
}
