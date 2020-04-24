public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int count = 0;
        int result = 0;
        for(int i = 0; i < nums.Length; i++) {
            //If Number Is One
            if(nums[i] == 1) {
                count ++;
                //If Count is Bigger Then Result
                if(count > result) {
                    result = count;
                }
                //Reset Count
            } else {
                count = 0;
            }
        }
        return result;
    }
}
