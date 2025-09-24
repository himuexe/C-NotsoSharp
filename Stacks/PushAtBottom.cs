// C# program to push an element at the bottom of a stack
// Time Complexity: O(n)
class Solution
{
    public static void PushAtBottom(Stack<int> st , int data){
        if(st.Count==0){
            st.Push(data);
            return;
        }
        int top = st.PoP();
        PushAtBottom(st,data);
        st.Push(top);
    }

}