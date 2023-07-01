public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        foreach(char c in s)
        {
            if(c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
            else if(c == ')'|| c == ']' || c == '}')
            {
                if(stack.Count == 0)
                {
                    return false;
                }
                if(stack.Peek() == '(' && c != ')')
                {
                    return false;
                }
                else if(stack.Peek() == '[' && c != ']')
                {
                    return false;
                }
                else if(stack.Peek() == '{' && c != '}')
                {
                    return false;
                }
                stack.Pop();
            }
        }
        if (stack.Count > 0)
        {
            return false;
        }
        return true;
    }
}