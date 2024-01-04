using System.Collections.Generic;

namespace CodeWars.Tasks
{
    public class Game
    {
        private readonly int[,] board;

        public Game(int[,] board)
        {
            this.board = board;
        }

        public int play()
        {
            int steps = 0;
            for (int x = 0; x < board.GetLength(0); x++)
            {
                for (int y = 0; y < board.GetLength(0); y++)
                {
                    if (board[y, x] == 1)
                    {
                        steps++;
                        clearItem(y, x);
                    }
                }
            }
            return steps;
        }

        private void clearItem(int y, int x)
        {
            if (board[y, x] == 0)
            {
                return;
            }
            board.SetValue(0, y, x);
            clearItem(y, x);
            try
            {
                clearItem(y, x + 1);
            }
            catch (IndexOutOfRangeException) { }
            try
            {
                clearItem(y, x - 1);
            }
            catch (IndexOutOfRangeException) { }
            try
            {
                clearItem(y - 1, x);
            }
            catch (IndexOutOfRangeException) { }
            try
            {
                clearItem(y + 1, x);
            }
            catch (IndexOutOfRangeException) { }
        }

    }
}
