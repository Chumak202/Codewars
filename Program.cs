using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    using System;
    using System.Collections.Generic;
    using System.Linq;



    class Connect4
    {
        private bool isfirsPlayerMove = true;
        private int[,] map = new int[6, 7];
        public string play(int col)
        {
            if (isfirsPlayerMove)
            {
                if (map[0, col] == 0)
                {
                    isfirsPlayerMove = !isfirsPlayerMove;
                    Cast(col, 1);
                }
                else
                {
                    return "Column full!";
                }
            }
            if (!isfirsPlayerMove)
            {
                if (map[0, col] == 0)
                {
                    isfirsPlayerMove = !isfirsPlayerMove;
                    Cast(col, 1);
                }
                else
                {
                    return "Column full!";
                }
            }
        }
        private void Cast(int column, int player)
        {
            for (int i = 5; i >= 0; i--)
            {
                if (map[i, column] == 0)
                {
                    map[i, column] = player;
                    break;
                }
            }
        }
        private int ChekWin(int player)
        {
            for (int y = 5; y >= 0; y--)
            {
                for (int x = 0; x < 6; x++)
                {
                    if ((map[y, x] == player))
                    {
                        try
                        {
                            if (map[y, x] == player && map[y, x + 1] == player && map[y, x + 2] == player && map[y, x + 3] == player) return 1;
                            if (map[y, x] == player && map[y, x - 1] == player && map[y, x - 2] == player && map[y, x - 3] == player) return 1;
                            if (map[y, x] == player && map[y, x + 1] == player && map[y, x + 2] == player && map[y, x - 1] == player) return 1;
                            if (map[y, x] == player && map[y, x - 1] == player && map[y, x - 2] == player && map[y, x + 1] == player) return 1;


                        }
                        catch (Exception)
                        {

                            throw;
                        }
                    }

                }
            }
        }
    }



    class GFG
    {


        public static void Main()
        {
            string[] data = { "John", "James", "Smith", "21-Jan-2000", "M" };
            Kata kata = new Kata();
            Console.WriteLine(kata.driver(data));
            Console.WriteLine(kata.driver(data).Length);

        }
    }
}
