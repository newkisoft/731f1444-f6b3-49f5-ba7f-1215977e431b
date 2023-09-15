using System;
using System.Collections.Generic;
using System.Linq;

namespace _731f1444_f6b3_49f5_ba7f_1215977e431b.Services;

public static class StringExtensions
{
    public static IList<string> SplitToList(this string input)
    {
        if (input.Length == 0)
            return new List<string>();

        var list = input.Split(" ").ToList();
        return list;
    }
}
