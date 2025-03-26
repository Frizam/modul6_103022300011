using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
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
            Debug.Assert(username.Length <= 100, "username maks 100 karakter");// precondition
            Debug.Assert(username != null, "username tidak boleh null");// precondition
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
            Debug.Assert(videoBaru != null, "video tidak boleh null");// precondition
            Debug.Assert(videoBaru.getPlayCount() < int.MaxValue, "video play count melebihi maks");// precondition
            uploadedVideos.Add(videoBaru); //menambah objek baru ke list
        }

        public void printAllVideoPlayCount() {
            Console.WriteLine($"User              : {Username}");
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video " + (i+1) + " judul     : " +uploadedVideos[i].getTitle());
                //Debug.Assert(i < 8, "Tidak bisa print lebih dari 8"); //postcondition
            }
            
        }
    }
}
