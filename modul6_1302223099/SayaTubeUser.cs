using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302223099
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username;
        public SayaTubeUser(string username)
        {
            Debug.Assert(username != null && username.Length < 100, "Username terlalu panjang atau kosong");
            Username = username;
            uploadedVideos = new List<SayaTubeVideo>();
        }
        public int GetTotalVideoPlayCount()
        {
            int sum = 0;
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                sum += uploadedVideos[i].GetPlayCount();
            }
            return sum;
        }
        public void AddVideo(SayaTubeVideo video)
        {
            Debug.Assert(video != null && video.GetPlayCount() < int.MaxValue, "Video tidak valid atau overflow play");
            uploadedVideos.Add(video);
        }
        public void PrintAllVideoPlayCount()
        {
            
            Console.WriteLine($"User: {Username}");
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
               if (i > 7)
                {
                    break;
                }
                Console.WriteLine($"Video {i+1} judul: {uploadedVideos[i].GetTitle()}");
            }
        }
    }
}
