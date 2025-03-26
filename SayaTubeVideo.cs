using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Debug.Assert(title != null, "judul tidak boleh null");// precondition
            Debug.Assert(title.Length <= 200, "judul maks 200 karakter");// precondition

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
            Debug.Assert(count > 0 && count <= 25000000, "maks 25.000.000");// precondition

            this.playCount += count; //menambahkan nilai count dengan nilai playCount sebelumnya
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"ID Video    : {id}");
            Console.WriteLine($"Title       : {title}");
            Console.WriteLine($"Play count  : {playCount}");
        }
    }
}
