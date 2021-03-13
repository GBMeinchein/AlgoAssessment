using System;

namespace TGS.Challenge
{
    /*
        Devise a function that takes an input 'n' (integer) and returns a string that is the
        decimal representation of that number grouped by commas after every 3 digits. 
        
        NOTES: You cannot use any built-in formatting functions to complete this task.

        Assume: 0 <= n < 1000000000

        1 -> "1"
        10 -> "10"
        100 -> "100"
        1000 -> "1,000"
        10000 -> "10,000"
        100000 -> "100,000"
        1000000 -> "1,000,000"
        35235235 -> "35,235,235"

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class FormatNumber
    {
        public string Format(int value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException();

            if (value > 1000000000)
                throw new ArgumentOutOfRangeException();

            var result = string.Empty;
            var valueString = value.ToString();
            var count = 0;

            for (int i = valueString.Length - 1; i >= 0; i--)
            {
                count++;
                result = valueString[i] + result;

                if (count == 3 && i != 0)
                {
                    count = 0;
                    result = "," + result;
                }
            }

            return result;
        }
    }
}
