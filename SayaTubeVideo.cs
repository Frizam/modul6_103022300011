using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300011
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Random rand = new Random();
            this.id = rand.Next(10000, 99999); //generate id random
            this.title = title;
            this.playCount = 0;
        }

        public string getTitle()
        {
            return this.title;
        }

        public int getPlayCount ()
        {
            return this.playCount;
        }

        public void IncreasePlayCount(int count) {
            this.playCount += count;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"ID Video    : {id}");
            Console.WriteLine($"Title       : {title}");
            Console.WriteLine($"Play count  : {playCount}");
        }
    }
}
