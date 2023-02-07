using System;
using System.Collections.Generic;

namespace managerspel
{
    class lag
    {
        internal bool index;
        int lagp;
        string namn;
        List<string> spelare;
        public lag(string nynamn, int lagpo)
        {
            namn = nynamn;
            lagp = lagpo;
            spelare = new List<string>();
        }

        public int Count { get; internal set; }

        public void lrspelare(string spelar)
        {
            spelare.Add(spelar);
        }
        public void skrivut()
        {
            foreach(string element in spelare)
            {
                var random = new Random();
                int index = random.Next(spelare.Count);
                Console.WriteLine(spelare[index]);
                Console.ReadLine();
            }
        }
        public int getlagpo()
        {
            return lagp;
        }
        public string getnynamn()
        {
            return namn;
        }
        public List<string> getspelare()
        {
            return spelare;
        }
    }
}

