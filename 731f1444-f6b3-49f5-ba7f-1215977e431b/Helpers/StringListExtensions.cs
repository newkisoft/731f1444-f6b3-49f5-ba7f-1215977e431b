using Microsoft.AspNetCore.Mvc;

namespace _731f1444_f6b3_49f5_ba7f_1215977e431b.Services;

public static class StringListExtensions
{
    public static IList<int> SplitToIntList(this IList<string> input)
    {
        var validNumbers = new List<int>();
        
        foreach (string numberStr in input)
        {
            if (int.TryParse(numberStr, out int number))
            {
                validNumbers.Add(number);
            }
            else
            {
                Console.WriteLine($"Invalid number: {numberStr}");
            }
        }
        return validNumbers;
    }
}
