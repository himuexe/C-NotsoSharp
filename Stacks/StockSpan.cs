public class StockSpan {
    public static void CalculateStockSpan(int[] stocks, int[] span) {
        Stack<int> st = new Stack<int>();
        span[0] = 1;
        st.Push(0);
        
        for(int i = 1; i < stocks.Length; i++) {
            int currPrice = stocks[i];
            
            while(st.Count > 0 && currPrice > stocks[st.Peek()]) {
                st.Pop();
            }
            
            if(st.Count == 0) {
                span[i] = i + 1;
            }
            else {
                int prevHigh = st.Peek();
                span[i] = i - prevHigh;
            }
            
            st.Push(i);
        }
    }
    
    static void Main(string[] args) {
        int[] stocks = {100, 80, 60, 70, 60, 85, 100};
        int[] span = new int[stocks.Length];
        CalculateStockSpan(stocks, span);
        
        for(int i = 0; i < span.Length; i++) {
            Console.Write(span[i] + " ");
        }
    }
}