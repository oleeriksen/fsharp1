using System;
using System.Collections.Generic;
using System.Linq;

namespace normal
{
    public class Intro
    {
       
        // return the sum of all the positive values in a
        public int SumPos(IEnumerable<int> a)
        {
            int res = 0;
            foreach (int v in a)
                if (v > 0)
                    res += v;
            return res;
        }


        public int SumPos2(IEnumerable<int> a)
        {
            return
                (from v in a
                 where v > 0
                 select v).Sum();
        }

    }
}
