using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302223099
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;
        public SayaTubeVideo(string title)
        {
            var rand = new Random();
            this.title = title;
            id = rand.Next(10000, 99999);
            playCount = 0;
        }
        public void IncreasePlayCount(int play)
        {
            playCount += play;
        }
        public string GetTitle()
        {
            return title;
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine($"ID         : {id}");
            Console.WriteLine($"Title      : {title}");
            Console.WriteLine($"Play Count : {playCount}");
        }
    }
}
