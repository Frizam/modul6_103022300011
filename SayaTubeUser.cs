using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300011
{
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        private string Username;

        public SayaTubeUser(string username)
        {
            this.Username = username;
            this.uploadedVideos = new List<SayaTubeVideo>(); //menyimpan list baru
        }

        public int GetTotalVideoPlayCount() {
            int total = 0;
            for (int i = 0; i < uploadedVideos.Count; i++) {
                total += uploadedVideos[i].getPlayCount(); //memabggil getPlaycount untuk mendapatkan value playCount dari video ke i
            }
            return total;
        }   

        public void AddVideo(SayaTubeVideo videoBaru) {
            
            uploadedVideos.Add(videoBaru); //menambah objek baru ke list
        }

        public void printAllVideoPlayCount() {
            Console.WriteLine($"User              : {Username}");
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video " + (i+1) + " judul     : " +uploadedVideos[i].getTitle());
            }
        }
    }
}
