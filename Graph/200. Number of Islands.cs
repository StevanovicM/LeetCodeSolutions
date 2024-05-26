public class Solution {
public int NumIslands(char[][] grid) {
        if (grid == null || grid.Length == 0) {
            return 0;
        }

        int numIslands = 0;
        int rows = grid.Length;
        int cols = grid[0].Length;

        for (int r = 0; r < rows; r++) {
            for (int c = 0; c < cols; c++) {
                if (grid[r][c] == '1') {
                    // Increment island count and perform DFS to mark this island
                    numIslands++;
                    Dfs(grid, r, c);
                }
            }
        }

        return numIslands;
    }

    private void Dfs(char[][] grid, int r, int c) {
        int rows = grid.Length;
        int cols = grid[0].Length;

        // Check boundaries
        if (r < 0 || c < 0 || r >= rows || c >= cols || grid[r][c] == '0') {
            return;
        }

        // Sink this part of the island
        grid[r][c] = '0';

        // Visit all adjacent cells
        Dfs(grid, r - 1, c); // Up
        Dfs(grid, r + 1, c); // Down
        Dfs(grid, r, c - 1); // Left
        Dfs(grid, r, c + 1); // Right
    }
}