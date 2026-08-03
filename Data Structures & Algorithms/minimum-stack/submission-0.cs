public class MinStack {

    // Min == the min value in stack when Val is at the top of the stack
    private Stack<(int Val, int Min)> stack;

    public MinStack() {
        stack = new Stack<(int, int)>();
    }
    
    public void Push(int val) {
        if (stack.Count == 0) {
            stack.Push((val, val));
        } else {
            int currentMin = Math.Min(val, stack.Peek().Min);
            stack.Push((val, currentMin));
        }        
    }
    
    public void Pop() {
        if (stack.Count > 0) {
            stack.Pop();
        }
    }
    
    public int Top() {
        return stack.Peek().Val;
    }
    
    public int GetMin() {
        return stack.Peek().Min;
    }
}
