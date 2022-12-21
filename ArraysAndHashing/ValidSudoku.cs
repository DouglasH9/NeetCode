using System;
namespace ArraysAndHashing
{
    public static class ValidSudoku
    {
        public static bool Calc(char[][] board)
        {
            HashSet<char>[] cols = new HashSet<char>[9];
            HashSet<char>[] rows = new HashSet<char>[9];
            HashSet<char>[] boxes = new HashSet<char>[9];

            for (int r = 0; r < 9; r++)
            {
                rows[r] = new HashSet<char>();
                cols[r] = new HashSet<char>();
                boxes[r] = new HashSet<char>();
            }

            for (int r = 0; r < 9; r++)
            {
                for (int c = 0; c < 9; c++)
                {
                    char value = board[r][c];
                    int boxIdx = (r / 3) * 3 + c / 3;

                    if (value == '.')
                        continue;
                    if (rows[r].Contains(value) |
                        cols[c].Contains(value) |
                        boxes[boxIdx].Contains(value))
                        return false;

                    rows[r].Add(value);
                    cols[c].Add(value);
                    boxes[boxIdx].Add(value);
                }
            }
            return true;
        }
    }
}

