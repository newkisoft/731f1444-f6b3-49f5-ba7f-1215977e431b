using Xunit;
using System;
using _731f1444_f6b3_49f5_ba7f_1215977e431b.Services;
using System.Linq;

using System.Collections.Generic; // Include this line for IEnumerable<>

namespace _731f1444_f6b3_49f5_ba7f_1215977e431b.Tests;

public class LongestSequenceServiceTest
{
    [Theory]
    [InlineData("6 1 5 9 2", new[] { 1,5,9})]
    [InlineData("1", new[] { 1 })]
    [InlineData("", new int[0])]
    [InlineData("1 2 0 3", new[] { 1, 2 })]
    public void GetLongestList_ReturnsLongestIncreasingSubsequence(string input, int[] expected)
    {
        // Arrange
        var service = new LongestSequenceService();

        // Act
        List<int> result = service.GetLongestList(input).ToList();

        // Assert
        Assert.Equal(expected, result.ToArray());
    }
}