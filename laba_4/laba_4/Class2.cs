using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_4
{
    public class StrClass
    {
        public string Split(string s, char c1, char c2)//1
        {
            var str = s.ToCharArray();//2
            string ready = "";//3
            for (int i = 0;//4
                i < str.Length;//5
                i++)//6
            {
                if (str[i] == c1)//7
                    str[i] = c2;//8
            }
            for (int i = 0;//9
                i < str.Length;//10
                i++)//11
                ready += str[i];//12
            return ready;//13
        }
    }
}

