using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameKata
{
    public class Game
    {

        public static int GetScore(List<int> pins)
        {
            int score = 0;
            for (int i = 0; i < pins.Count;i=i+2 )
            {
                for (int j = 1; j < pins.Count;j=j+2 )
                { 
                    if (pins[i] + pins[j] == 10)
                        score = score+pins[i]+pins[i +1] + pins[i +1];
                    if (pins[i] == 10)
                        score = score+pins[i] + pins[i + 1] + pins[j+1];
                    else
                        score = score+pins[i]+pins[j];
                }
            }

            return score;
        }
    }
}
