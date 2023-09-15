using Microsoft.AspNetCore.Mvc;

namespace _731f1444_f6b3_49f5_ba7f_1215977e431b.Services;

public interface ILongestSequenceService
{    
    IEnumerable<int> GetLongestList(string input);
}
