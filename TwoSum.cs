public class Solution {
    public int[] TwoSum(int[] nums, int target) {
            Dictionary<int, int> Box = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++) {
                int diff = target - nums[i];

                //只跟Box內的比較，先比對、再加入
                if (Box.ContainsKey(diff)) {
                    return new int[] { Box[diff], i };
                }

                //找不到就放進去Box，避免跟自己重複配對。
                if (!Box.ContainsKey(nums[i])) {
                    Box[nums[i]] = i;
                }
            }

            return null;
        }
}
