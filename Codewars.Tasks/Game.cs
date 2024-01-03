using System.Collections.Generic;

namespace CodeWars.Tasks
{
    public class Game
    {
        private int[,] board;
        private List<List<int>> coordinat = new List<List<int>>();

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
                    if (board[x, y] == 1)
                    {
                        steps++;
                        coordinat.Add(new List<int> { x, y });
                        board.SetValue(0, y, x);
                        bordReplace(x, y);
                        coordinat.Clear();
                    }
                }
            }
            return steps;
        }

        private void bordReplace(int x, int y)
        {
            //try
            //{
            //    if (board[x, y] == 1)
            //    {
            //        coordinat.Add(new List<int> { x, y });
            //        board.SetValue(0, y, x);
            //        bordReplace(x, y);
            //    }

            //}
            //catch (IndexOutOfRangeException) { }
            try
            {
                if (board[y, x + 1] == 1)
                {
                    coordinat.Add(new List<int> { x + 1, y });
                    board.SetValue(0, y, x + 1);
                    bordReplace(x + 1, y);
                }

            }
            catch (IndexOutOfRangeException) { }
            try
            {
                if (board[y, x - 1] == 1)
                {
                    coordinat.Add(new List<int> { x - 1, y });
                    board.SetValue(0, y, x - 1);
                    bordReplace(x - 1, y);
                }

            }
            catch (IndexOutOfRangeException) { }
            try
            {
                if (board[y - 1, x] == 1)
                {
                    coordinat.Add(new List<int> { x, y - 1 });
                    board.SetValue(0, y - 1, x);
                    bordReplace(x, y - 1);
                }

            }
            catch (IndexOutOfRangeException) { }
            try
            {
                if (board[y + 1, x] == 1)
                {
                    coordinat.Add(new List<int> { x, y + 1 });
                    board.SetValue(0, y + 1, x);
                    bordReplace(x, y + 1);
                }

            }
            catch (IndexOutOfRangeException) { }






        }

    }
}
