public class Solution {
    public int[] PlusOne(int[] digits) {
        bool increment = false;
        int arrayLength = digits.Length;
        if (digits[arrayLength - 1] == 9)
        {
            increment = true;
        }
        else 
        {
            digits[arrayLength - 1] += 1;
        }
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if(digits[i] == 9 && increment == true)
            {
                digits[i] = 0;
            }
            else if (increment == true)
            {
                digits[i]++;
                increment = false;
            }
        }
        if(increment == true)
        {
            int[] newArray = digits.Prepend(1).ToArray();
            return newArray;
        }
        else
        {
            return digits;
        }

    }
}