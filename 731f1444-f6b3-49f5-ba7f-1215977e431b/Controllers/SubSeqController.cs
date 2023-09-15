using _731f1444_f6b3_49f5_ba7f_1215977e431b.Services;
using Microsoft.AspNetCore.Mvc;

namespace _731f1444_f6b3_49f5_ba7f_1215977e431b.Controllers;

[ApiController]
[Route("[controller]")]
public class SubSeqController : ControllerBase
{
    private readonly ILogger<SubSeqController> _logger;
    private readonly ILongestSequenceService _longestService;

    public SubSeqController(ILogger<SubSeqController> logger, ILongestSequenceService longestSequenceService)
    {
        _logger = logger;
        _longestService = longestSequenceService;
    }

    [HttpPost("upload")]
    public IEnumerable<int> UploadFile(IFormFile file)
    {
        if (file == null || file.Length == 0)
        {
            // Handle the case where no file is provided
            // You can return an error response or appropriate status code here
            return new List<int>();
        }

        using (var reader = new StreamReader(file.OpenReadStream()))
        {
            var fileContent = reader.ReadToEnd();
            return _longestService.GetLongestList(fileContent);
        }
    }
}
