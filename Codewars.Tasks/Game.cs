using System.Collections.Generic;

namespace CodeWars.Tasks
{
    public class Game
    {
        private int maxNumberLen;
        private int board;
        public Game(int board)
        {
            this.board = board;
            //Console.WriteLine(board);
            maxNumberLen = board * (board + 1) * 2;
        }

        public List<int> play(List<int> lines)
        {
            int l = board * 2 + 1;

            //lines.ForEach(x => Console.Write("{0} ", x));
            lines.Sort();
            int iterr = 1;
            while (iterr != 0)
            {
                iterr = 0;
                for (int i = 0; i < lines.Count; i++)
                {
                    int mod = lines[i] % l;

                    bool vertical = mod == 0 || mod > board;

                    if (!vertical)
                    {
                        int U = board * 2 + 1;
                        int L = board;
                        int R = board + 1;
                        int countUp = 0;
                        if (lines.Contains(lines[i] + U)) countUp++;
                        if (lines.Contains(lines[i] + R)) countUp++;
                        if (lines.Contains(lines[i] + L)) countUp++;

                        if (countUp == 2)
                        {
                            if (!lines.Contains(lines[i] + U))
                            {
                                if (lines[i] + U > 0 && lines[i] + U < maxNumberLen)
                                {
                                    lines.Add(lines[i] + U);
                                    iterr++;
                                    continue;
                                }
                            }
                            if (!lines.Contains(lines[i] + R))
                            {
                                if (lines[i] + R > 0 && lines[i] + R < maxNumberLen)
                                {
                                    lines.Add(lines[i] + R);
                                    iterr++;
                                    continue;
                                }
                            }
                            if (!lines.Contains(lines[i] + L))
                            {
                                if (lines[i] + L > 0 && lines[i] + L < maxNumberLen)
                                {
                                    lines.Add(lines[i] + L);
                                    iterr++;
                                    continue;
                                }
                            }
                        }
                        else
                        {
                            int countDown = 0;
                            if (lines.Contains(lines[i] - U)) countDown++;
                            if (lines.Contains(lines[i] - R)) countDown++;
                            if (lines.Contains(lines[i] - L)) countDown++;

                            if (countDown == 2)
                            {
                                if (!lines.Contains(lines[i] - U))
                                {
                                    if (lines[i] - U > 0 && lines[i] - U < maxNumberLen)
                                    {
                                        lines.Add(lines[i] - U);
                                        iterr++;
                                        continue;
                                    }
                                }
                                if (!lines.Contains(lines[i] - R))
                                {
                                    if (lines[i] - R > 0 && lines[i] - R < maxNumberLen)
                                    {
                                        lines.Add(lines[i] - R);
                                        iterr++;
                                        continue;
                                    }
                                }
                                if (!lines.Contains(lines[i] - L))
                                {
                                    if (lines[i] - L > 0 && lines[i] - L < maxNumberLen)
                                    {
                                        lines.Add(lines[i] - L);
                                        iterr++;
                                        continue;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return lines.OrderBy(i => i).ToList();
        }
    }
}
