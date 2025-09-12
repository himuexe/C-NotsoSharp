public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        List<int> list = new List<int>();
        if(matrix == null || matrix.Length == 0) return list;
        int firstRow=0 , firstCol = 0 ;
        int lastRow =matrix.Length-1 , lastCol=matrix[0].Length-1;
        while(firstRow <= lastRow && firstCol <= lastCol){
            for(int i=firstCol; i <= lastCol ; i++){
                list.Add(matrix[firstRow][i]);
            }
            firstRow++;
            for(int i=firstRow; i <= lastRow; i++){
                list.Add(matrix[i][lastCol]);
            }
            lastCol--;
            if(firstRow <= lastRow){
                for(int i=lastCol ; i >= firstCol ;i--){
                    list.Add(matrix[lastRow][i]);
                }
                lastRow--;
            }
            if(firstCol <= lastCol){
                for(int i=lastRow;i >= firstRow ; i--){
                    list.Add(matrix[i][firstCol]);
                }
                firstCol++;
            }
        }
        return list;
    }
}