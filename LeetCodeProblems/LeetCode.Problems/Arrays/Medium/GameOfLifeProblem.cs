using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Arrays.Medium
{
    /// <summary>
    /// 289. Game of Life
    /// https://leetcode.com/problems/game-of-life/
    /// Runtime: 292 ms, faster than 64.76% of C# online submissions for Game of Life.
    /// Not in place solution.!!! :-(
    /// </summary>
    public class GameOfLifeProblem
    {
        public void GameOfLife(int[][] board)
        {
            var n = board[0].Length;
            var m = board.GetLength(0);
            var buff = new int[m][];
            for (int i = 0; i < m; i++)
            {
                buff[i] = new int[n];
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (board[i][j] == 0) continue;

                    if (i + 1 < m)
                        buff[i + 1][j] += 1;
                    if (i - 1 >= 0)
                        buff[i - 1][j] += 1;
                    if (j + 1 < n)
                        buff[i][j + 1] += 1;
                    if (j - 1 >= 0)
                        buff[i][j - 1] += 1;
                    if (i + 1 < m && j + 1 < n)
                        buff[i + 1][j + 1] += 1;
                    if (i + 1 < m && j - 1 >= 0)
                        buff[i + 1][j - 1] += 1;
                    if (i - 1 >= 0 && j + 1 < n)
                        buff[i - 1][j + 1] += 1;
                    if (i - 1 >= 0 && j - 1 >= 0)
                        buff[i - 1][j - 1] += 1;
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (buff[i][j] < 2)
                        board[i][j] = 0;
                    if(buff[i][j] >= 2 && buff[i][j] <= 3)
                        board[i][j] = board[i][j];
                    if (buff[i][j] == 3)
                        board[i][j] = 1;
                    if (buff[i][j] > 3)
                        board[i][j] = 0;
                }
            }

            //Utils.Helperrs.PrintMatrix(buff);
        }
    }
}
