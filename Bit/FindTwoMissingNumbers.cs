namespace Experimental.Bit
{
    public static class FindTwoMissingNumbers
    {
        public static int[] FindTwoMissingNumbersUsingAvg(int[] arr)
        {
            if (arr.Length <= 0)
                return null;
            var n = arr.Length;

            var sumOfNumbers = 0;

            for (var i = 0; i < n; i++)
            {
                sumOfNumbers += arr[i];
            }
            
            var sumOfMissing = (n + 2)*(n + 3)/2 - sumOfNumbers;
            var avg = sumOfMissing / 2;

            var sumOfLowerHalf = 0;

            for (var i = 0; i < n; i++)
            {
                if (arr[i] <= avg)
                    sumOfLowerHalf += arr[i];
            }

            var missing1 = (avg)*(avg + 1)/2 - sumOfLowerHalf;
            var missing2 = sumOfMissing - missing1;

            return new []{missing1, missing2};
        }
    }
}
