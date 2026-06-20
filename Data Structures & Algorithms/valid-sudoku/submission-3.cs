public class Solution {
    private char[][] board;
    public bool IsValidSudoku(char[][] board) {
        this.board = board;
        for(int i = 0; i < 9; i++){
            if(!(IsValidRow(i) && IsValidColumn(i) && IsValidBox(i))){
                return false;
            }
        }
        return true;
    }

    private bool IsValidRow(int row){
        HashSet<char> set = new HashSet<char>();
        for(int i = 0; i < 9; i++){
            if(board[row][i] != '.' && !set.Add(board[row][i])){
                return false;
            }
        }
        return true;
    }

    private bool IsValidColumn(int col){
        HashSet<char> set = new HashSet<char>();
        for(int i = 0; i < 9; i++){
            if(board[i][col] != '.' && !set.Add(board[i][col])){
                return false;
            }
        }
        return true;
    }

    private bool IsValidBox(int index){
        int row = (index / 3) * 3;
        int col = (index % 3) * 3;
        HashSet<char> set = new HashSet<char>();

        for(int i = row; i < row + 3; i++){
            for(int j = col; j < col + 3; j++){
                if(board[i][j] != '.' && !set.Add(board[i][j])){
                    return false;
                }
            }
        }
        return true;
    }
}
