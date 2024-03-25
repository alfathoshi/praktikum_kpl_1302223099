using System;
using System.Collections.Generic;
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
            Username = username;
            uploadedVideos = new List<SayaTubeVideo>();
        }
        public int GetTotalVideoPlayCount()
        {
            return uploadedVideos.Count;
        }
        public void AddVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
        }
        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine($"User");
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine($"Video {i+1} judul: {uploadedVideos[i].GetTitle()}");
            }
        }
    }
}
