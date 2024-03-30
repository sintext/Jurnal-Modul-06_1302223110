using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace Jurnal_Modul_06_1302223110
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        internal SayaTubeVideo(String judul)
        {
            Contract.Requires(judul.Length <= 200 && judul != null);

            title = judul;

            playCount = 0;

            id = new Random().Next(10000, 99999);
        }

        public void increasePlayCount(int play)
        {
            Contract.Requires(play >= 0 && play <= 25000000);
            try
            {
                checked
                {
                    playCount += play;
                }            
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!!");
            }
        }

        public void printVideoDetails()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Id video: " + id);
            Console.WriteLine("Play Count: " + playCount);
        }
        public int getplayCount() 
        {
            return playCount;
        }

        public String getTitle()
        {
            return title;
        }
    }
}
