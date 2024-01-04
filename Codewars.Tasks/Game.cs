using System.Collections.Generic;


namespace CodeWars.Tasks
{
    public class Game
    {
        public int fish(string shoal)
        {
            int youFishSize = 1;
            int youFishHonor = 0;
            var sortShoal = from i in shoal
                            where i != '0'
                            orderby i
                            select i;
            foreach (var i in sortShoal)
            {
                if (youFishHonor >= youFishSize * 4)
                {
                    youFishHonor -= youFishSize * 4;
                    youFishSize++;

                }
                if (int.Parse(i.ToString()) <= youFishSize)
                {
                    youFishHonor += int.Parse(i.ToString());
                }
                else
                {
                    return youFishSize;
                }
            }
            if (youFishHonor == youFishSize * 4)
            {
                youFishSize++;
                youFishHonor = 0;
            }
            return youFishSize;
        }
    }
}
