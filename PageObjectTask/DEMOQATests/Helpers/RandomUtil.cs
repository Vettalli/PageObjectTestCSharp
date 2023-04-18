using System;

namespace DEMOQATests.Helpers;

public class RandomUtil
{
    public static int GetRandomInteger()
    {
        var random = new Random();
        var minNumber = 1;
        var maxNumber = 254;

        return random.Next(minNumber, maxNumber);
    }
}