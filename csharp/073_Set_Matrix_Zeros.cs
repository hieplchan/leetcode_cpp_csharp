public class Solution {
    public void SetZeroes(int[][] matrix) {
        int rol = matrix.Length, col = matrix[0].Length;
        bool shouldFillFirstRow = false;

        // 1st loop to mark flag, use first cell of row/col to mark
        // matrix[0][0] can not be used for both row/col -> use shouldFillFirstRow;
        for (int j = 0; j < col; j++) {
            if (matrix[0][j] == 0) {
                shouldFillFirstRow = true;
                break;
            }
        }
        for (int i = 1; i < rol; i++) {
            for (int j = 0; j < col; j++) {
                if (matrix[i][j] == 0) 
                    matrix[i][0] = matrix[0][j] = 0;                    
            }
        }

        // 2nd loop to set value, reverse loop revent first cell being set to zero
        for (int i = rol - 1; i >= 1; i--) {
            for (int j = col - 1; j >= 0; j--) {
                if ((matrix[i][0] == 0) || (matrix[0][j] == 0)) 
                    matrix[i][j] = 0;
            }
        }
        for (int j = 0; j < col; j++) {
            if (shouldFillFirstRow) 
                matrix[0][j] = 0;
        }
    }
}