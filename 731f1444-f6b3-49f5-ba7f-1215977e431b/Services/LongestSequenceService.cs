using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace _731f1444_f6b3_49f5_ba7f_1215977e431b.Services;

public class LongestSequenceService : ILongestSequenceService
{   

    public IEnumerable<int> GetLongestList(string input)
    {
        var stringList =  input.SplitToList();
        var intList = stringList.SplitToIntList();
        List<int> longestSeq = new List<int>();

        if(intList.Count == 0)
            return longestSeq;
        List<int> currentSeq = new List<int> { intList[0] };

        for (int i = 1; i < intList.Count; i++)
        {
            if (intList[i] > intList[i - 1])
            {
                currentSeq.Add(intList[i]);
            }
            else
            {
                if (currentSeq.Count > longestSeq.Count)
                {
                    longestSeq = new List<int>(currentSeq);
                }
                currentSeq.Clear();
                currentSeq.Add(intList[i]);
            }
        }

        // Check if the last sequence is the longest
        if (currentSeq.Count > longestSeq.Count)
        {
            longestSeq = new List<int>(currentSeq);
        }

        return longestSeq;
    }
}
