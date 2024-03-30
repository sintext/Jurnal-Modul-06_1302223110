using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace Jurnal_Modul_06_1302223110
{
    internal class SayaTubeUser
    {
        private int ID;
        private String Username;
        private List<SayaTubeVideo> uploadedVideos;

        internal SayaTubeUser(string username)
        {
            Contract.Requires(username != null && username.Length <= 100);
            this.Username = username;
            this.uploadedVideos = new List<SayaTubeVideo>();

        }

        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                total += uploadedVideos[i].getplayCount();
            }
            return total;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlayCount()
        {
            Contract.Ensures(this.j <= 8);

            Console.WriteLine("Username: " + Username);
            for (int j = 0;  j < uploadedVideos.Count; j++)
            {
                Console.WriteLine("Video "+ j + "judul:" + uploadedVideos[j].getTitle() );
            }
        }
    } 
}
