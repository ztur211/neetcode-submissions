public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int len = temperatures.Length;
        int[] result = new int[len];

        // Use stack to store indices of temperatures
        Stack<int> stack = new Stack<int>();

        // Loop from right to left
        for (int i = len - 1; i >= 0; i--) {

            // Pop indices where temperature is less than or equal to current
            while (stack.Count != 0 && (temperatures[stack.Peek()] <= temperatures[i])) {
                stack.Pop();
            }

            // Peek next warmer temp, result is difference in days
            if (stack.Count != 0) {
                result[i] = stack.Peek() - i;
            }

            // Push index to stack to compare future iterations
            stack.Push(i);
        }
        return result;
    }
}
