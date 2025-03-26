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
            this.uploadedVideos = new List<SayaTubeVideo>();
        }

        public int GetTotalVideoPlayCount() {
            int total = 0;
            for (int i = 0; i < uploadedVideos.Count; i++) {
                total += uploadedVideos[i].getPlayCount();
            }
            return total;
        }   

        public void AddVideo(SayaTubeVideo videoBaru) {
            
            uploadedVideos.Add(videoBaru);
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
