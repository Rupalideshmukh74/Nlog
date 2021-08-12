using System;
using System.Collections.Generic;
using System.Text;

namespace NlogSession
{
    public class AddNumber
    {
        private readonly NLogC nlog = new NLogC();
        public int sum(int firstNumber, int secondNumber)
        {
            if (firstNumber == 0 || secondNumber == 0)
            {
                nlog.LogDebug("Debug Unsuccessfull : sum()");
                nlog.LogError("Input numbrs cannot be zero");
                nlog.LogWarn("firstNumber or secondNumber should not equal to zero");
            }
            int result = firstNumber + secondNumber;
            nlog.LogDebug("Debug Successfull : sum()");
            nlog.LogInfo("Sum Method Passed, Result : " + result);
            return result;
        }
    }
}