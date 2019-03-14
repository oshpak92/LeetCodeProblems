using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Arrays.Medium
{
    /// <summary>
    /// 79. Word Search
    /// https://leetcode.com/problems/word-search/
    /// Runtime: 824 ms, faster than 5.15% of C# online submissions for Word Search.
    /// Memory Usage: 43.7 MB, less than 6.45% of C# online submissions for Word Search.
    /// </summary>
    public class WordSearchProblem
    {
        public bool Exist(char[,] board, string word)
        {
            if (string.IsNullOrEmpty(word))
                return true;

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if(board[i,j] == word[0])
                    {
                        if (BuildWord(board, i, j, 0, word, new HashSet<string>()))
                            return true;
                    }
                }
            }
            return false;
        }

        private bool BuildWord(char[,] board, int i, int j, int pointer, string word, HashSet<string> usedCoordinates)
        {
            if (usedCoordinates.Contains($"{i}_{j}"))
                return false;

            if (pointer == word.Length)
                return true;

            if (i >= board.GetLength(0) || i < 0)
                return false;
            if (j >= board.GetLength(1) || j < 0)
                return false;

            if (word[pointer] != board[i, j])
                return false;

            usedCoordinates.Add($"{i}_{j}");

            return BuildWord(board, i + 1, j, pointer + 1, word, new HashSet<string>(usedCoordinates))
                || BuildWord(board, i - 1, j, pointer + 1, word, new HashSet<string>(usedCoordinates))
                || BuildWord(board, i, j + 1, pointer + 1, word, new HashSet<string>(usedCoordinates))
                || BuildWord(board, i, j - 1, pointer + 1, word, new HashSet<string>(usedCoordinates));
        }
    }
}
